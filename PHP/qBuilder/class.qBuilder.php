<?php

require_once('../cfg/cfg.php');

class qBuilder{

private $sql = '';
private $affectedRows = null;

public function __construct()
    {
        global $cfg;
        $host = $cfg['db']['host'];
        $user = $cfg['db']['user'];
        $pass = $cfg['db']['pass'];
        $db = $cfg['db']['db'];

        $this->dbConnection = mysqli_connect($host,$user,$pass,$db);
    }


public function build($sql,$execute = false){

	$this->sql = $sql;
	
	if($execute === true){
		$this->execute();
	}
}

public function execute(){
	if(!mysqli_query($this->dbConnection,$this->sql)){
		echo mysqli_error($this->dbConnection);
	}else{
		$this->affectedRows = mysqli_num_rows(mysqli_query($this->dbConnection,$this->sql));
	}
}

public function getAffectedRows(){
	if($this->affectedRows !== null){
		return $this->affectedRows;
	}else{
		return "N/A, no query executed";
	}
}
}
?>