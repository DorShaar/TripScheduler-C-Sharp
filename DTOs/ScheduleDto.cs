// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: schedule_dto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using System;
using System.Linq;
using TripScheduler.Interfaces;
using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ScheduleDto
{

    /// <summary>Holder for reflection information generated from schedule_dto.proto</summary>
    public static partial class ScheduleDtoReflection
    {

        #region Descriptor
        /// <summary>File descriptor for schedule_dto.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static ScheduleDtoReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "ChJzY2hlZHVsZV9kdG8ucHJvdG8SDHNjaGVkdWxlX2R0bxofZ29vZ2xlL3By",
                  "b3RvYnVmL3RpbWVzdGFtcC5wcm90byI/CghTY2hlZHVsZRIKCgJJRBgBIAEo",
                  "BRInCgpFdmVudHNMaXN0GAIgAygLMhMuc2NoZWR1bGVfZHRvLkV2ZW50IlgK",
                  "BUV2ZW50EhEKCUV2ZW50TmFtZRgBIAEoCRIQCghMb2NhdGlvbhgCIAEoCRIq",
                  "CglFdmVudFRpbWUYAyABKAsyFy5zY2hlZHVsZV9kdG8uRXZlbnRUaW1lInsK",
                  "CUV2ZW50VGltZRIVCg1EdXJhdGlvbkluU2VjGAEgASgFEh8KF1ByZWNhdXRp",
                  "b25EdXJhdGlvbkluU2VjGAIgASgFEjYKEkFjdHVhbFN0YXJ0aW5nVGltZRgD",
                  "IAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBiBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ScheduleDto.Schedule), global::ScheduleDto.Schedule.Parser, new[]{ "ID", "EventsList" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ScheduleDto.Event), global::ScheduleDto.Event.Parser, new[]{ "EventName", "Location", "EventTime" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ScheduleDto.EventTime), global::ScheduleDto.EventTime.Parser, new[]{ "DurationInSec", "PrecautionDurationInSec", "ActualStartingTime" }, null, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class Schedule : pb::IMessage<Schedule>, ISchedule
    {
        private static readonly pb::MessageParser<Schedule> _parser = new pb::MessageParser<Schedule>(() => new Schedule());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Schedule> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::ScheduleDto.ScheduleDtoReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Schedule()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Schedule(Schedule other) : this()
        {
            iD_ = other.iD_;
            eventsList_ = other.eventsList_.Clone();
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Schedule Clone()
        {
            return new Schedule(this);
        }

        /// <summary>Field number for the "ID" field.</summary>
        public const int IDFieldNumber = 1;
        private int iD_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int ID
        {
            get { return iD_; }
            set
            {
                iD_ = value;
            }
        }

        /// <summary>Field number for the "EventsList" field.</summary>
        public const int EventsListFieldNumber = 2;
        private static readonly pb::FieldCodec<global::ScheduleDto.Event> _repeated_eventsList_codec
            = pb::FieldCodec.ForMessage(18, global::ScheduleDto.Event.Parser);
        private readonly pbc::RepeatedField<global::ScheduleDto.Event> eventsList_ = new pbc::RepeatedField<global::ScheduleDto.Event>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::ScheduleDto.Event> EventsList
        {
            get { return eventsList_; }
        }

        scg.IEnumerable<IEvent> ISchedule.EventsList => EventsList.AsEnumerable();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as Schedule);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Schedule other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ID != other.ID) return false;
            if (!eventsList_.Equals(other.eventsList_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (ID != 0) hash ^= ID.GetHashCode();
            hash ^= eventsList_.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (ID != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(ID);
            }
            eventsList_.WriteTo(output, _repeated_eventsList_codec);
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (ID != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(ID);
            }
            size += eventsList_.CalculateSize(_repeated_eventsList_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Schedule other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ID != 0)
            {
                ID = other.ID;
            }
            eventsList_.Add(other.eventsList_);
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 8:
                        {
                            ID = input.ReadInt32();
                            break;
                        }
                    case 18:
                        {
                            eventsList_.AddEntriesFrom(input, _repeated_eventsList_codec);
                            break;
                        }
                }
            }
        }

    }

    public sealed partial class Event : pb::IMessage<Event>, IEvent
    {
        private static readonly pb::MessageParser<Event> _parser = new pb::MessageParser<Event>(() => new Event());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Event> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::ScheduleDto.ScheduleDtoReflection.Descriptor.MessageTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Event()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Event(Event other) : this()
        {
            eventName_ = other.eventName_;
            location_ = other.location_;
            eventTime_ = other.eventTime_ != null ? other.eventTime_.Clone() : null;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Event Clone()
        {
            return new Event(this);
        }

        /// <summary>Field number for the "EventName" field.</summary>
        public const int EventNameFieldNumber = 1;
        private string eventName_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string EventName
        {
            get { return eventName_; }
            set
            {
                eventName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "Location" field.</summary>
        public const int LocationFieldNumber = 2;
        private string location_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Location
        {
            get { return location_; }
            set
            {
                location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "EventTime" field.</summary>
        public const int EventTimeFieldNumber = 3;
        private global::ScheduleDto.EventTime eventTime_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::ScheduleDto.EventTime EventTime
        {
            get { return eventTime_; }
            set
            {
                eventTime_ = value;
            }
        }

        IEventTime IEvent.EventTime => EventTime;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as Event);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Event other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (EventName != other.EventName) return false;
            if (Location != other.Location) return false;
            if (!object.Equals(EventTime, other.EventTime)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (EventName.Length != 0) hash ^= EventName.GetHashCode();
            if (Location.Length != 0) hash ^= Location.GetHashCode();
            if (eventTime_ != null) hash ^= EventTime.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (EventName.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(EventName);
            }
            if (Location.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Location);
            }
            if (eventTime_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(EventTime);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (EventName.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(EventName);
            }
            if (Location.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
            }
            if (eventTime_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(EventTime);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Event other)
        {
            if (other == null)
            {
                return;
            }
            if (other.EventName.Length != 0)
            {
                EventName = other.EventName;
            }
            if (other.Location.Length != 0)
            {
                Location = other.Location;
            }
            if (other.eventTime_ != null)
            {
                if (eventTime_ == null)
                {
                    EventTime = new global::ScheduleDto.EventTime();
                }
                EventTime.MergeFrom(other.EventTime);
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 10:
                        {
                            EventName = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Location = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (eventTime_ == null)
                            {
                                EventTime = new global::ScheduleDto.EventTime();
                            }
                            input.ReadMessage(EventTime);
                            break;
                        }
                }
            }
        }

    }

    public sealed partial class EventTime : pb::IMessage<EventTime>, IEventTime
    {
        private static readonly pb::MessageParser<EventTime> _parser = new pb::MessageParser<EventTime>(() => new EventTime());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<EventTime> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::ScheduleDto.ScheduleDtoReflection.Descriptor.MessageTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public EventTime()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public EventTime(EventTime other) : this()
        {
            durationInSec_ = other.durationInSec_;
            precautionDurationInSec_ = other.precautionDurationInSec_;
            actualStartingTime_ = other.actualStartingTime_ != null ? other.actualStartingTime_.Clone() : null;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public EventTime Clone()
        {
            return new EventTime(this);
        }

        /// <summary>Field number for the "DurationInSec" field.</summary>
        public const int DurationInSecFieldNumber = 1;
        private int durationInSec_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int DurationInSec
        {
            get { return durationInSec_; }
            set
            {
                durationInSec_ = value;
            }
        }

        /// <summary>Field number for the "PrecautionDurationInSec" field.</summary>
        public const int PrecautionDurationInSecFieldNumber = 2;
        private int precautionDurationInSec_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int PrecautionDurationInSec
        {
            get { return precautionDurationInSec_; }
            set
            {
                precautionDurationInSec_ = value;
            }
        }

        /// <summary>Field number for the "ActualStartingTime" field.</summary>
        public const int ActualStartingTimeFieldNumber = 3;
        private global::Google.Protobuf.WellKnownTypes.Timestamp actualStartingTime_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Protobuf.WellKnownTypes.Timestamp ActualStartingTime
        {
            get { return actualStartingTime_; }
            set
            {
                actualStartingTime_ = value;
            }
        }

        DateTime IEventTime.ActualStartingTime => ActualStartingTime.ToDateTime();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as EventTime);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(EventTime other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (DurationInSec != other.DurationInSec) return false;
            if (PrecautionDurationInSec != other.PrecautionDurationInSec) return false;
            if (!object.Equals(ActualStartingTime, other.ActualStartingTime)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (DurationInSec != 0) hash ^= DurationInSec.GetHashCode();
            if (PrecautionDurationInSec != 0) hash ^= PrecautionDurationInSec.GetHashCode();
            if (actualStartingTime_ != null) hash ^= ActualStartingTime.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (DurationInSec != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(DurationInSec);
            }
            if (PrecautionDurationInSec != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(PrecautionDurationInSec);
            }
            if (actualStartingTime_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(ActualStartingTime);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (DurationInSec != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(DurationInSec);
            }
            if (PrecautionDurationInSec != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(PrecautionDurationInSec);
            }
            if (actualStartingTime_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(ActualStartingTime);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(EventTime other)
        {
            if (other == null)
            {
                return;
            }
            if (other.DurationInSec != 0)
            {
                DurationInSec = other.DurationInSec;
            }
            if (other.PrecautionDurationInSec != 0)
            {
                PrecautionDurationInSec = other.PrecautionDurationInSec;
            }
            if (other.actualStartingTime_ != null)
            {
                if (actualStartingTime_ == null)
                {
                    ActualStartingTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                }
                ActualStartingTime.MergeFrom(other.ActualStartingTime);
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 8:
                        {
                            DurationInSec = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            PrecautionDurationInSec = input.ReadInt32();
                            break;
                        }
                    case 26:
                        {
                            if (actualStartingTime_ == null)
                            {
                                ActualStartingTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(ActualStartingTime);
                            break;
                        }
                }
            }
        }

    }

    #endregion

}

#endregion Designer generated code
