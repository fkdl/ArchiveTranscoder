﻿/// This file was originally auto-generated by xsd, Version=1.1.4322.2032:
///		1. A model XML file was constructed by hand
///		2. Ran: xsd ArchiverBatchFile.xml ;this creates the xsd.
///		3. Ran: xsd ArchiverBatchFile.xsd \c \n:ArchiveTranscoder  ;this creates ArchiverBatchFile.cs with proper namespace
///		4. Added this file to the project.
/// This file is now the source for the ArchiverBatchFile schema and XML instance files.  To generate the XML instance model
/// simply create an instance of the class with sample data, and run the XML Serializer over it.
using System.Xml.Serialization;

namespace ArchiveTranscoder 
{    
	/// <remarks/>
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public class ArchiveTranscoderBatch 
	{ 
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Server;

		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string DatabaseName;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Job", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ArchiveTranscoderJob[] Job;
	}
    
	/// <remarks/>
	public class ArchiveTranscoderJob 
	{
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string WMProfile;
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ArchiveName;
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string BaseName;
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Path;
                
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Target", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
		public ArchiveTranscoderJobTarget[] Target;
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Segment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ArchiveTranscoderJobSegment[] Segment;
	}
    
	/// <remarks/>
	public class ArchiveTranscoderJobTarget 
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Type;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string CreateAsx;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string CreateWbv;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string SlideBaseUrl;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string PresentationUrl;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string WmvUrl;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AsxUrl;
	}

	/// <remarks/>
	public class ArchiveTranscoderJobSegmentVideoDescriptor 
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string VideoCname;

		///Used to uniquely identify a particular camera or video source in the case
		///where this particpant is sending multiple video streams. <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string VideoName;
	}

	/// <remarks/>
	public class ArchiveTranscoderJobSegmentAudioDescriptor 
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AudioCname;

		///Used to uniquely identify a particular audio source in the case
		///where this particpant is sending multiple audio streams (eg. WM Playback capability)<remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AudioName;
	}

	/// <remarks/>
	public class ArchiveTranscoderJobSegmentPresentationDescriptor 
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string PresentationCname;

		///Wire format such as 'RTDocument' or 'CPNav' or 'Video' <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string PresentationFormat;

        ///If this is non null and the PresentationFormat is 'Video', then build a presentation from video frames. <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VideoDescriptor", IsNullable = true)]
        public ArchiveTranscoderJobSegmentVideoDescriptor VideoDescriptor;

	}

    
	/// <remarks/>
	public class ArchiveTranscoderJobSegment 
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string StartTime;        
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string EndTime;
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("VideoDescriptor", IsNullable=true)]
		public ArchiveTranscoderJobSegmentVideoDescriptor VideoDescriptor;
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AudioDescriptor", IsNullable=true)]
		public ArchiveTranscoderJobSegmentAudioDescriptor[] AudioDescriptor;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PresentationDescriptor", IsNullable=true)]
		public ArchiveTranscoderJobSegmentPresentationDescriptor PresentationDescriptor;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SlideDecks", IsNullable=true)]
		public ArchiveTranscoderJobSlideDeck[] SlideDecks;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Flags", IsNullable = true)]
        public string[] Flags;

	}

	public class ArchiveTranscoderJobSlideDeck
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Title;
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string DeckGuid;
        
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Path;	
	}

}
