; Complete the reverseArray function below.
(defn reverseArray [a]
 (rseq a)
)

(def fptr (get (System/getenv) "OUTPUT_PATH"))

(def arr-count (Integer/parseInt (clojure.string/trim (read-line))))

(def arr (vec (map #(Integer/parseInt %) (clojure.string/split (read-line) #" "))))

(def res (reverseArray arr))

(spit fptr (clojure.string/join " " res) :append true)
(spit fptr "\n" :append true)
