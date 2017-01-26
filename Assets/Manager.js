var WeaponKally=true;
var WeaponKampilan=false;
var WeaponKampilanLock:GameObject;
var WeaponBambooSpear=false;
var WeaponBambooSpearLock:GameObject;
var WeaponSumpak=false;
var WeaponSumpakLock:GameObject;
var WeaponGlockPistol=false;
var WeaponGlockPistolLock:GameObject;
var pGold =0;
var UseWeaponInt=1;
var WaveInt=1;
var GoldText:UI.Text;
var WaveLock2:GameObject;
var WaveLock3:GameObject;
var WaveLock4:GameObject;
var WaveLock5:GameObject;
var firtsLoad=0;


public function LoadLevelManager(Level:String){
	
	Application.LoadLevel(Level);
}
function WaveLockManager(){
	if(WaveInt ==2 ){
		WaveLock2.active=false;
	}
	if(WaveInt ==3 ){
		WaveLock3.active=false;
	}
	if(WaveInt ==4 ){
		WaveLock4.active=false;
	}
	if(WaveInt ==5 ){
		WaveLock5.active=false;
	}
	
}
function Save(){
	
	PlayerPrefs.SetInt("pGold", pGold);
	PlayerPrefs.SetInt("UseWeaponInt", UseWeaponInt);
	PlayerPrefs.SetInt("WaveInt", WaveInt);
	PlayerPrefs.SetInt("firtsLoad",firtsLoad);
}
function Load(){
	
	pGold=PlayerPrefs.GetInt("pGold");
	UseWeaponInt=PlayerPrefs.GetInt("UseWeaponInt");
	WaveInt=PlayerPrefs.GetInt("WaveInt");
	firtsLoad=PlayerPrefs.GetInt("firtsLoad");
}

public function UseWeapon( weaponInt:int){
	
	UseWeaponInt=weaponInt;
}
public function BuyKampilan(){
	if(pGold >= 5000){
		pGold -=5000;
		WeaponKampilan=true;
		WeaponKampilanLock.active =false;
		Save();
	}
	
}
public function BuyBambooSPear(){
	if(pGold >= 7000){
		pGold -=7000;
		WeaponBambooSpear=true;
		WeaponBambooSpearLock.active =false;
		Save();
	}
}
public function BuySumpak(){
	if(pGold >= 10000){
		pGold -=10000;
		WeaponSumpak=true;
		WeaponSumpakLock.active =false;
		Save();
	}
}
public function BuyPistol(){
	if(pGold >= 15000){
		pGold -=15000;
		WeaponGlockPistol=true;
		WeaponGlockPistolLock.active =false;
		Save();
	}
}
function Start () {
Load();

if(firtsLoad ==0){
	 UseWeaponInt=1;
WaveInt=1;
	firtsLoad=1;
	Save();
}
}

function Update () {
WaveLockManager();
GoldText.text = "Gold =" + pGold.ToString("F0");

}