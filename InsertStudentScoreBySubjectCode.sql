DELIMITER $$

CREATE DEFINER=`root`@`localhost`
PROCEDURE InsertStudentScoreBySubjectCode (
    IN p_subject_code VARCHAR(100)
)
BEGIN

    DELETE sc
    FROM tbl_studentscore sc
    JOIN tbl_exam e ON sc.exam_id = e.exam_id
    JOIN tbl_assignment a ON e.assignment_id = a.assignment_id
    JOIN tbl_subject sub ON a.subject_id = sub.subject_id
    WHERE (p_subject_code IS NULL OR sub.subject_code = p_subject_code);

    INSERT INTO tbl_studentscore (student_id, exam_id, total_score, grade)
    SELECT
        s.student_id,
        e.exam_id,
        COUNT(*) AS score,
        CASE
            WHEN COUNT(*) >= 75 THEN 'Passed'
            ELSE 'Failed'
        END AS remarks
    FROM tbl_studentexamanswer s
    JOIN tbl_examquestion q ON s.examquestion_id = q.examquestion_id
    JOIN tbl_option o ON q.question_id = o.question_id -- Fixed join to match your .sql files
    JOIN tbl_exam e ON q.exam_id = e.exam_id
    JOIN tbl_assignment a ON e.assignment_id = a.assignment_id
    JOIN tbl_subject sub ON a.subject_id = sub.subject_id
    WHERE o.is_correct = 1 -- Matched to your tbl_option column
      AND s.option_id = o.option_id -- Comparing IDs is safer than comparing text
      AND (p_subject_code IS NULL OR sub.subject_code = p_subject_code)
    GROUP BY s.student_id, e.exam_id;
END $$

DELIMITER ;