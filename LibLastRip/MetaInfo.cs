// LibLastRip - A Last.FM ripping library for TheLastRipper
// Copyright (C) 2007  Jop... (Jonas F. Jensen).
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

using System;

namespace LibLastRip
{
	public class MetaInfo : System.EventArgs, IMetaMusic
	{
		protected System.String _Station;
		protected System.String _Artist;
		protected System.String _Track;
		protected System.String _Album;
		protected System.String _AlbumcoverSmall;
		protected System.String _AlbumcoverMedium;
		protected System.String _AlbumcoverLarge;
		protected System.String _Trackduration;
		protected System.String _Trackprogress;
		protected System.Boolean _Streaming = true;

		public MetaInfo(System.String Data)
		{
			System.String []Lines = Data.Split(new System.Char[] {'\n'});
			foreach(System.String Line in Lines)
			{
				System.String []Opts = Line.Split(new System.Char[] {'='});
				switch(Opts[0].ToLower())
				{
					case "station":
						this._Station = Opts[1];
						break;
					case "artist":
						this._Artist = Opts[1];
						break;
					case "track":
						this._Track = Opts[1];
						break;
					case "album":
						this._Album = Opts[1];
						break;
					case "albumcover_small":
						this._AlbumcoverSmall = Opts[1];
						break;
					case "albumcover_medium":
						this._AlbumcoverMedium = Opts[1];
						break;
					case "albumcover_large":
						this._AlbumcoverLarge = Opts[1];
						break;
					case "trackduration":
						this._Trackduration = Opts[1];
						break;
					case "trackprogress":
						this._Trackprogress = Opts[1];
						break;
					case "streaming":
						if(Opts[1].ToLower()=="false")
						{
							
						}
					break;
				}
			}
			
			//We've got to have something to write as ID3tag's, filename and directories
			if(this._Track == null || this._Track == "")
				this._Track = "unknown";
			if(this._Album == null || this._Album == "")
				this._Album = "unknown";
			if(this._Artist == null || this._Artist == "")
				this._Artist = "unknown";
		}
		
		public System.String Station
		{
			get
			{
				return this._Station;
			}
		}
		
		public System.String Artist
		{
			get
			{
				return this._Artist;
			}
		}
		
		public System.String Track
		{
			get
			{
				return this._Track;
			}
		}
		
		public System.String Album
		{
			get
			{
				return this._Album;
			}
		}
		
		public System.String AlbumcoverSmall
		{
			get
			{
				return this._AlbumcoverSmall;
			}
		}
		
		public System.String AlbumcoverMedium
		{
			get
			{
				return this._AlbumcoverMedium;
			}
		}
		
		public System.String AlbumcoverLarge
		{
			get
			{
				return this._AlbumcoverLarge;
			}
		}
		
		public System.String Trackduration
		{
			get
			{
				return this._Trackduration;
			}
		}
		
		public System.String Trackprogress
		{
			get
			{
				return this._Trackprogress;
			}
		}
		
		public System.Boolean Streaming
		{
			get
			{
				return this._Streaming;
			}
		}
		
		public override System.String ToString()
		{
			System.String OutStr = "";
			
			if(this._Streaming)
			{
				OutStr += "Track: " + this._Artist + " - " + this._Album + " - " + this._Track + "\n";
				OutStr += "From: " + this._Station + "\n";
				OutStr += "Duration: " + this._Trackduration;
			}else{
				OutStr = "Streaming: " + this._Streaming.ToString();
			}
			return OutStr;
		}
		
		public override System.Int32 GetHashCode()
		{
			return (this._Album + this._Artist + this._Track).GetHashCode();
		}
		new public static System.Boolean Equals(System.Object Obj1, System.Object Obj2)
		{
			if(Obj1.GetType()==typeof(MetaInfo)&&Obj2.GetType()==typeof(MetaInfo))
			{
				if(((MetaInfo)Obj1).GetHashCode()==((MetaInfo)Obj2).GetHashCode())
				{
					return true;
				}
			}
			return false;
		}

		///<summary>
		///Appends ID3tag to a file
		///</summary>
		///<param name="Stream">A Stream representation of the file, which ID3tags should be appended</param>
		public void AppendID3(System.IO.FileStream Stream)
		{
			StreamAbstraction SA = new StreamAbstraction(Stream);
			this.AppendID3(SA);
		}
		
		///<summary>
		///Appends ID3tag to a file
		///</summary>
		///<param name="Path">Path of the file, which ID3tags should be appended</param>
		public void AppendID3(System.String Path)
		{
			TagLib.File.LocalFileAbstraction FA = new TagLib.File.LocalFileAbstraction(Path);
			this.AppendID3(FA);
		}
		
		///<summary>
		///Appends ID3tag to an IFileAbstraction
		///</summary>
		protected void AppendID3(TagLib.File.IFileAbstraction IFile)
		{
			//Create TagLib file from file abstraction 
			TagLib.File File = TagLib.File.Create(IFile);
			
			//Create id3v2 tags by trying to read them, with permission to create if none existing
			File.GetTag(TagLib.TagTypes.Id3v2, true);

			//Set track title
			File.Tag.Title = this.Track;
			
			//Set Artists
			File.Tag.Performers =  new System.String[]{this.Artist};
			File.Tag.AlbumArtists = new System.String[]{this.Artist};
			
			//Set album
			File.Tag.Album = this.Album;
			
			//Add comment, defining from where the music was recorded.
			File.Tag.Comment = "Recorded with TheLastRipper from " + this.Station;

			//TODO: Add picture using TagLib-Sharp
			//TagLib.Picture.CreateFromFile()
			
			//Saves the Current file
			File.Save();
		}
	}
}
