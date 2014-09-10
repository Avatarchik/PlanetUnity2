

using UnityEngine;


//
// Autogenerated by gaxb ( https://github.com/SmallPlanet/gaxb )
//

using System;
using System.Xml;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;


public partial class PURawImage : PURawImageBase {
	
	public PURawImage()
	{
	}
	
	
	public PURawImage(
			string resourcePath,
			Color color,
			Vector4 uvRect ) : this()
	{
		this.resourcePath = resourcePath;
		this.resourcePathExists = true;

		this.color = color;
		this.colorExists = true;

		this.uvRect = uvRect;
		this.uvRectExists = true;
	}

	
	
	public PURawImage(
			string resourcePath,
			Color color,
			Vector4 uvRect,
			Vector4 bounds,
			Vector3 position,
			Vector2 size,
			Vector3 rotation,
			Vector3 scale,
			Vector2 pivot,
			string anchor,
			bool active,
			bool mask,
			float lastY,
			float lastX,
			string shader,
			string title,
			string tag,
			string tag1,
			string tag2,
			string tag3,
			string tag4,
			string tag5,
			string tag6 ) : this()
	{
		this.resourcePath = resourcePath;
		this.resourcePathExists = true;

		this.color = color;
		this.colorExists = true;

		this.uvRect = uvRect;
		this.uvRectExists = true;

		this.bounds = bounds;
		this.boundsExists = true;

		this.position = position;
		this.positionExists = true;

		this.size = size;
		this.sizeExists = true;

		this.rotation = rotation;
		this.rotationExists = true;

		this.scale = scale;
		this.scaleExists = true;

		this.pivot = pivot;
		this.pivotExists = true;

		this.anchor = anchor;
		this.anchorExists = true;

		this.active = active;
		this.activeExists = true;

		this.mask = mask;
		this.maskExists = true;

		this.lastY = lastY;
		this.lastYExists = true;

		this.lastX = lastX;
		this.lastXExists = true;

		this.shader = shader;
		this.shaderExists = true;

		this.title = title;
		this.titleExists = true;

		this.tag = tag;
		this.tagExists = true;

		this.tag1 = tag1;
		this.tag1Exists = true;

		this.tag2 = tag2;
		this.tag2Exists = true;

		this.tag3 = tag3;
		this.tag3Exists = true;

		this.tag4 = tag4;
		this.tag4Exists = true;

		this.tag5 = tag5;
		this.tag5Exists = true;

		this.tag6 = tag6;
		this.tag6Exists = true;
	}


}




public class PURawImageBase : PUGameObject {


	private static Type planetOverride = Type.GetType("PlanetUnityOverride");
	private static MethodInfo processStringMethod = planetOverride.GetMethod("processString", BindingFlags.Public | BindingFlags.Static);




	// XML Attributes
	public string resourcePath;
	public bool resourcePathExists;

	public Color color;
	public bool colorExists;

	public Vector4 uvRect;
	public bool uvRectExists;




	
	public void SetResourcePath(string v) { resourcePath = v; resourcePathExists = true; } 
	public void SetColor(Color v) { color = v; colorExists = true; } 
	public void SetUvRect(Vector4 v) { uvRect = v; uvRectExists = true; } 


	public override void gaxb_unload()
	{
		base.gaxb_unload();

	}
	
	public void gaxb_addToParent()
	{
		if(parent != null)
		{
			FieldInfo parentField = parent.GetType().GetField("RawImage");
			List<object> parentChildren = null;
			
			if(parentField != null)
			{
				parentField.SetValue(parent, this);
				
				parentField = parent.GetType().GetField("RawImageExists");
				parentField.SetValue(parent, true);
			}
			else
			{
				parentField = parent.GetType().GetField("RawImages");
				
				if(parentField != null)
				{
					parentChildren = (List<object>)(parentField.GetValue(parent));
				}
				else
				{
					parentField = parent.GetType().GetField("GameObjects");
					if(parentField != null)
					{
						parentChildren = (List<object>)(parentField.GetValue(parent));
					}
				}
				if(parentChildren == null)
				{
					FieldInfo childrenField = parent.GetType().GetField("children");
					if(childrenField != null)
					{
						parentChildren = (List<object>)childrenField.GetValue(parent);
					}
				}
				if(parentChildren != null)
				{
					parentChildren.Add(this);
				}
				
			}
		}
	}

	public override void gaxb_load(XmlReader reader, object _parent, Hashtable args)
	{
		base.gaxb_load(reader, _parent, args);

		if(reader == null && _parent == null)
			return;
		
		parent = _parent;
		
		if(this.GetType() == typeof( PURawImage ))
		{
			gaxb_addToParent();
		}
		
		xmlns = reader.GetAttribute("xmlns");
		

		string attr;
		attr = reader.GetAttribute("resourcePath");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { resourcePath = attr; resourcePathExists = true; } 
		
		attr = reader.GetAttribute("color");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { color = new Color().PUParse(attr); colorExists = true; } 
		
		attr = reader.GetAttribute("uvRect");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { uvRect = new Vector4().PUParse(attr); uvRectExists = true; } 
		

	}
	
	
	
	
	
	
	
	public override void gaxb_appendXMLAttributes(StringBuilder sb)
	{
		base.gaxb_appendXMLAttributes(sb);

		if(resourcePathExists) { sb.AppendFormat (" {0}=\"{1}\"", "resourcePath", resourcePath); }
		if(colorExists) { sb.AppendFormat (" {0}=\"{1}\"", "color", color); }
		if(uvRectExists) { sb.AppendFormat (" {0}=\"{1}\"", "uvRect", uvRect); }

	}
	
	public override void gaxb_appendXMLSequences(StringBuilder sb)
	{
		base.gaxb_appendXMLSequences(sb);


	}
	
	public override void gaxb_appendXML(StringBuilder sb)
	{
		if(sb.Length == 0)
		{
			sb.AppendFormat ("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
		}
		
		sb.AppendFormat ("<{0}", "RawImage");
		
		if(xmlns != null)
		{
			sb.AppendFormat (" {0}=\"{1}\"", "xmlns", xmlns);
		}
		
		gaxb_appendXMLAttributes(sb);
		
		
		StringBuilder seq = new StringBuilder();
		seq.AppendFormat(" ");
		gaxb_appendXMLSequences(seq);
		
		if(seq.Length == 1)
		{
			sb.AppendFormat (" />");
		}
		else
		{
			sb.AppendFormat (">{0}</{1}>", seq.ToString(), "RawImage");
		}
	}
}
