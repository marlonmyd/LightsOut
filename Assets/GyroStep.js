
var x:Vector3;
var y=0.0;
var Speed=5.0;
var Time=0.0;
var movementScale=5.0;
function OnGUI () {
		//GUI.text (Rect (10,10,150,100), x.x.ToString()+x.y.ToString()+x.z.ToString());

GUI.Button (Rect (0, 30, 500, 200), GUIContent ( x.x.ToString()+x.y.ToString()+x.z.ToString()));

			
	}


	function LateUpdate() {
		Input.gyro.enabled = true;
		// A "spirit level" - the dot product of the gravity and the Y axis (ie, Vector3.up)
		// is a measure of how far the device is from level on that axis (it will be zero
		// if the device is perfectly level). This value can be used to position an object
		// to act as the "bubble".
		x=Input.gyro.gravity;
		//transform.rotation = Input.gyro.attitude;
		
		if(x.x >=0.03){
			
			//transform.position.x -=Speed* 0.1;
		}
	var pos = transform.position;
		pos.y = Vector3.Dot(Input.gyro.gravity, Vector3.forward) * movementScale;
		transform.position = pos;
	}