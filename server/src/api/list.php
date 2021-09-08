<?php
    require_once '../classes/SQLConnection.php';

    $conn = new SQLConnection();
    $result = ["result" => false];
    if (!$conn->connect())
    {
        echo json_encode($result);
        return;
    }

    $stmt = $conn->query("SELECT id, last_name, first_name FROM users;");
    $result["result"] = $stmt->execute();
    $list = $stmt->fetchAll();
    $result["list"] = $list;

    echo json_encode($result);
?>