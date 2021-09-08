<?php
    // SQL接続クラス
    class SQLConnection
    {
        private $pdo;       // PDO

        // コンストラクタ
        public function __construct()
        {
            $this->pdo = null;
        }

        // 接続
        public function connect()
        {
            try
            {
                $this->pdo = new PDO("mysql:dbname=name_list;host=db", "develop", "develop");
            }
            catch(PDOException $e) { return false; }
            return true;
        }

        // クエリ発行
        public function query(string $sql)
        {
            if ($this->pdo === null) { return null; }
            $prepare = $this->pdo->prepare($sql);
            return new SQLPrepare($prepare);
        }
    }

    // プリペア
    class SQLPrepare
    {
        private $prepare;       // プリペア

        // コンストラクタ
        public function __construct($prepare)
        {
            $this->prepare = $prepare;
        }

        // 値のバインド
        public function bind($param, $value, $type)
        {
            $this->prepare->bindValue($param, $value, $type);
        }

        // 実行
        public function execute()
        {
            $this->prepare->execute();
        }

        // フェッチ
        public function fetchAll()
        {
            return $this->prepare->fetchAll(PDO::FETCH_ASSOC);
        }
    }
?>