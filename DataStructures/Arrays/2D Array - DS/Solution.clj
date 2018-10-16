; Complete the hourglassSum function below.
(defn hourglassSum [arr]
  (apply max (vector (reduce + (vector (nth (nth arr 0) 0) (nth (nth arr 0) 1) (nth (nth arr 0) 2) (nth (nth arr 1) 1) (nth (nth arr 2) 0) (nth (nth arr 2) 1) (nth (nth arr 2) 2)))
    (reduce + (vector (nth (nth arr 0) 1) (nth (nth arr 0) 2) (nth (nth arr 0) 3) (nth (nth arr 1) 2) (nth (nth arr 2) 1) (nth (nth arr 2) 2) (nth (nth arr 2) 3)))
    (reduce + (vector (nth (nth arr 0) 2) (nth (nth arr 0) 3) (nth (nth arr 0) 4) (nth (nth arr 1) 3) (nth (nth arr 2) 2) (nth (nth arr 2) 3) (nth (nth arr 2) 4)))
    (reduce + (vector (nth (nth arr 0) 3) (nth (nth arr 0) 4) (nth (nth arr 0) 5) (nth (nth arr 1) 4) (nth (nth arr 2) 3) (nth (nth arr 2) 4) (nth (nth arr 2) 5)))
    (reduce + (vector (nth (nth arr 1) 0) (nth (nth arr 1) 1) (nth (nth arr 1) 2) (nth (nth arr 2) 1) (nth (nth arr 3) 0) (nth (nth arr 3) 1) (nth (nth arr 3) 2)))
    (reduce + (vector (nth (nth arr 1) 1) (nth (nth arr 1) 2) (nth (nth arr 1) 3) (nth (nth arr 2) 2) (nth (nth arr 3) 1) (nth (nth arr 3) 2) (nth (nth arr 3) 3)))
    (reduce + (vector (nth (nth arr 1) 2) (nth (nth arr 1) 3) (nth (nth arr 1) 4) (nth (nth arr 2) 3) (nth (nth arr 3) 2) (nth (nth arr 3) 3) (nth (nth arr 3) 4)))
    (reduce + (vector (nth (nth arr 1) 3) (nth (nth arr 1) 4) (nth (nth arr 1) 5) (nth (nth arr 2) 4) (nth (nth arr 3) 3) (nth (nth arr 3) 4) (nth (nth arr 3) 5)))
    (reduce + (vector (nth (nth arr 2) 0) (nth (nth arr 2) 1) (nth (nth arr 2) 2) (nth (nth arr 3) 1) (nth (nth arr 4) 0) (nth (nth arr 4) 1) (nth (nth arr 4) 2)))
    (reduce + (vector (nth (nth arr 2) 1) (nth (nth arr 2) 2) (nth (nth arr 2) 3) (nth (nth arr 3) 2) (nth (nth arr 4) 1) (nth (nth arr 4) 2) (nth (nth arr 4) 3)))
    (reduce + (vector (nth (nth arr 2) 2) (nth (nth arr 2) 3) (nth (nth arr 2) 4) (nth (nth arr 3) 3) (nth (nth arr 4) 2) (nth (nth arr 4) 3) (nth (nth arr 4) 4)))
    (reduce + (vector (nth (nth arr 2) 3) (nth (nth arr 2) 4) (nth (nth arr 2) 5) (nth (nth arr 3) 4) (nth (nth arr 4) 3) (nth (nth arr 4) 4) (nth (nth arr 4) 5)))
    (reduce + (vector (nth (nth arr 3) 0) (nth (nth arr 3) 1) (nth (nth arr 3) 2) (nth (nth arr 4) 1) (nth (nth arr 5) 0) (nth (nth arr 5) 1) (nth (nth arr 5) 2)))
    (reduce + (vector (nth (nth arr 3) 1) (nth (nth arr 3) 2) (nth (nth arr 3) 3) (nth (nth arr 4) 2) (nth (nth arr 5) 1) (nth (nth arr 5) 2) (nth (nth arr 5) 3)))
    (reduce + (vector (nth (nth arr 3) 2) (nth (nth arr 3) 3) (nth (nth arr 3) 4) (nth (nth arr 4) 3) (nth (nth arr 5) 2) (nth (nth arr 5) 3) (nth (nth arr 5) 4)))
    (reduce + (vector (nth (nth arr 3) 3) (nth (nth arr 3) 4) (nth (nth arr 3) 5) (nth (nth arr 4) 4) (nth (nth arr 5) 3) (nth (nth arr 5) 4) (nth (nth arr 5) 5)))
  ))
)

(def fptr (get (System/getenv) "OUTPUT_PATH"))

(def arr [])

(doseq [_ (range 6)]
    (def arr (conj arr (vec (map #(Integer/parseInt %) (clojure.string/split (read-line) #" ")))))
)

(def result (hourglassSum arr))

(spit fptr (str result "\n") :append true)
