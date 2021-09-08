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
    }
?>