(def nd (clojure.string/split (read-line) #" "))

(def n (Integer/parseInt (clojure.string/trim (nth nd 0))))

(def d (Integer/parseInt (clojure.string/trim (nth nd 1))))

(def a (vec (map #(Integer/parseInt %) (clojure.string/split (read-line) #" "))))

(def newVec (concat (drop d a) (drop-last (- n d) a)))

(defn printElements [aVector]
  (if (not (empty? aVector))
    (do
      (print (nth aVector 0) "")
      (recur (drop 1 aVector)))))

(printElements newVec)


