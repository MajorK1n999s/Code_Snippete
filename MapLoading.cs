using UnityEngine. UI;
using UnityEngine. Networking;
using System;
Unity Script | 0 references
public class Map: MonoBehaviour
{
public string apikey;
public float lat = 33.85660618894087f;
public float lon= h
float float.operator -(float value)
public int zoom = 14;
4 references
public enum resolution { low = 1, high = 2 };
public resolution mapResolution = resolution. low;
4 references
public enum type { roadmap, satellite, gybrid, terrain };
public type mapType = type.roadmap;
private string url = "";
private int mapWidth = 640;
private int mapHeight = 640;
private bool mapIsLoading = false; //not used. Can be used to know that the map is loading
private Rect rect;
private string apiKeyLast;
private float latLast = -33.85660618894087f;
private float lonLast = 151.21500701957325f;
private int zoomLast = 14;
private resolution mapResolutionLast = resolution. low;
private type mapTypeLast = type.roadmap;
private bool updateMap = true;
// Start is called before the first frame update
Unity Message | 0 references
void Start()
{
StartCoroutine (GetGoogleMap());
rect = gameObject.GetComponent<RawImage>().rectTransform. rect;
mapWidth = (int) Math. Round (rect.width);
mapHeight (int) Math. Round (rect.height);
}
// Update is called once per frame
Unity Message | 0 references
void Update()
{
if (updateMap && (apiKeyLast != apiKey || !Mathf. Approximately (latLast, lat) || !Mathf. Approximately (lonLast, lon) || zoomLast != zoom || mapResolution Last != mapResolution || mapType Last != mapType))
{
rect = gameObject.GetComponent<RawImage>().rectTransform. rect;
mapWidth = (int) Math. Round (rect.width);
mapHeight = (int) Math. Round (rect.height);
StartCoroutine (GetGoogleMap());
updateMap = false;
}
I
2 references
IEnumerator GetGoogleMap()
{
url = "https://maps.googleapis.com/maps/api/staticmap?center=" 1 lat + ","lon + "&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + mapResolution + "&maptype="+ mapType + "&key="
+ apikey; string string.operator +(string left, object right)
mapIsLoading = true;
UnityWebRequest www = UnityWebRequestTexture. GetTexture (url);
yield return www.SendWebRequest();
if (www.result != UnityWebRequest. Result. Success)
{
Debug. Log("WWW ERROR: " + www.error);
}
else
{
mapIsLoading = false;
gameObject.GetComponent<Raw Image>(). texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
apiKeyLast apikey;
latLast lat;
lonLast lon;
zoomLast = zoom;
mapResolutionLast = mapResolution;
mapTypeLast = mapType;
updateMap = true;
}