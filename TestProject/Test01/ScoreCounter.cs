using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 生徒データを読み込み、studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            //生徒ごとの点数データを入れるリストオブジェクトを生成
            List<Student> students = new List<Student>();
            //ファイルから一気に読み込む
            string[] lines = File.ReadAllLines(filePath);
            //読み込んだ行の数だけ繰り返す
            foreach (string line in lines) {
                string[] items = line.Split(',');
                //Studentオブジェクトを生成
                Student student = new Student {
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);
            }
            return students;
        }

        //メソッドの概要： 生徒別点数を求める
        public IDictionary<string, int> GetPerStudentScore() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    dict[student.Subject] += student.Score;
                } else {
                    dict[student.Subject] = student.Score;
                }
            }
            return dict;
        }
    }
}
