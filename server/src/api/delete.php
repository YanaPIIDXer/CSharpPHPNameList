<?php
    require_once "../classes/SQLConnection.php";

    $json = file_get_contents("php://input");
    $contents = json_decode($json, true);
    
    $id = $contents["id"];
    $result = ["result" => false];
    if ($id === null)
    {
        echo json_encode($result);
        return;
    }
    
    $conn = new SQLConnection();
    if (!$conn->connect())
    {
        echo json_encode($result);
        return;
    }
    $stmt = $conn->query("DELETE FROM users WHERE id = :id;");
    $stmt->bind(":id", $id, PDO::PARAM_INT);

    $result["result"] = $stmt->execute();
    echo json_encode($result);
?>