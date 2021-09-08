<?php
    require_once '../classes/SQLConnection.php';

    $conn = new SQLConnection();
    if (!$conn->connect())
    {
        echo json_encode(["result" => false]);
        return;
    }

    $result = ["result" => true];
    $stmt = $conn->query("SELECT last_name, first_name FROM users;");
    $stmt->execute();
    $list = $stmt->fetchAll();
    $result["list"] = $list;

    echo json_encode($result);
?>