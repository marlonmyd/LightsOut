#pragma strict
var Player:Transform;


function Start () {

}

function Update () {
	
	Player =GameObject.Find("Player").transform;
transform.LookAt(Player);
}