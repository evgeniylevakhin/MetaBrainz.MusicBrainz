﻿using System;
using System.Xml.Serialization;

using MetaBrainz.MusicBrainz.Model.Lists;

namespace MetaBrainz.MusicBrainz.Model {

  [Serializable]
  public class Isrc : Entity {

    [XmlElement("recording-list")] public RecordingList RecordingList;

  }

}