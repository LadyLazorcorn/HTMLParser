using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTMLParser : MonoBehaviour {

	private string url = "![Image](Image_icon.png)";
	private string[] text;
	private string img;
	private string imgUrl;

	private string[] urls = {"![Image](Image_icon.png)", "![Image](Image_icon2.png)", "![Image](Image_icon3.png)"}; //Markdown syntax


	// Use this for initialization
	void Start () {
		img = url.Substring(2,5);
		imgUrl = url.Substring (9, 14);


		for (int i = 0; i < urls.Length; i++) {
			int klammerAuf = urls [i].IndexOf ("[");
			int klammerZu = urls [i].IndexOf ("]");
			img = urls [i].Substring (klammerAuf+1, ((klammerZu-1) - klammerAuf));
			//Debug.Log(img);

			int klammerNAuf = urls [i].IndexOf ("(");
			int klammerNZu = urls [i].IndexOf (")");
			img = urls [i].Substring (klammerNAuf+1, ((klammerNZu-1) - klammerNAuf));

			Debug.Log ("<p><img alt=\"" + img + "\" src=\"" + imgUrl + "\" /></p>");
		}
	}

}
