﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SMTPlacement
{
    /// <summary>
    /// Describes and SMT Tube Feeder
    /// </summary>
    public class SMDTubeFeeder : MaterialCarrier
    {
        /// <summary>
        /// The unique identifier of the vibratoryb tube feeder base of which this
        /// tube feeder position is a member.  If lanes are not specifically labeled, 
        /// both the UniqueIdentifer field and this property should be populated
        /// with the same value.
        /// </summary>
        public string BaseUniqueIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// The friendly name of the tube feeder base.
        /// </summary>
        public string BaseName
        {
            get;
            set;
        }

        /// <summary>
        /// The position number of this tube feeder position within its base.
        /// </summary>
        public int LaneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The width of this lane within the tube feeder (in mm)
        /// </summary>
        public double Width
        {
            get;
            set;
        }

        /// <summary>
        /// The offset between this lane and the next adjacent lane in this tube feeder
        /// </summary>
        public double Pitch
        {
            get;
            set;
        }
    }
}
