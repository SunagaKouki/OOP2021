namespace Test01 {
    class Student {
        //学生の名前（読み込み専用）
        public string Name { get; private set; }
        //科目名
        public string Subject { get; set; }
        //点数
        public int Score { get; set; }
    }
}
