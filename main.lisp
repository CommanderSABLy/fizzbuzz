(defun is-mult (n multiple)
  (= (rem n multiple) 0))

(defun fizzbuzz (&optional iterations fizz buzz)
  (let ((iterations (or iterations 100)))
       (let ((fizz (or fizz 3)))
       (let ((buzz (or buzz 5)))
    (dotimes (i (+ 1 iterations))
        (progn
          (let ((first-mult (is-mult i fizz))
                (second-mult (is-mult i buzz)))
            (if first-mult
                (princ "Fizz"))
            (if second-mult
                (princ "Buzz"))
            (if (not (or first-mult second-mult))
                (princ i))
            (princ #\linefeed))))))))
(fizzbuzz 50 4 9)