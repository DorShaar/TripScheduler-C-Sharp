// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: schedule_rank.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using TripScheduler.Interfaces;
using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dto {

  /// <summary>Holder for reflection information generated from schedule_rank.proto</summary>
  public static partial class ScheduleRankReflection {

    #region Descriptor
    /// <summary>File descriptor for schedule_rank.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScheduleRankReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNzY2hlZHVsZV9yYW5rLnByb3RvEgNkdG8iKAoMU2NoZWR1bGVSYW5rEgoK",
            "AklEGAEgASgFEgwKBFJhbmsYAiABKAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dto.ScheduleRank), global::Dto.ScheduleRank.Parser, new[]{ "ID", "Rank" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ScheduleRank : pb::IMessage<ScheduleRank>, IScheduleRank {
    private static readonly pb::MessageParser<ScheduleRank> _parser = new pb::MessageParser<ScheduleRank>(() => new ScheduleRank());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ScheduleRank> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dto.ScheduleRankReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ScheduleRank() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ScheduleRank(ScheduleRank other) : this() {
      iD_ = other.iD_;
      rank_ = other.rank_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ScheduleRank Clone() {
      return new ScheduleRank(this);
    }

    /// <summary>Field number for the "ID" field.</summary>
    public const int IDFieldNumber = 1;
    private int iD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ID {
      get { return iD_; }
      set {
        iD_ = value;
      }
    }

    /// <summary>Field number for the "Rank" field.</summary>
    public const int RankFieldNumber = 2;
    private double rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ScheduleRank);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ScheduleRank other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ID != other.ID) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Rank, other.Rank)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ID != 0) hash ^= ID.GetHashCode();
      if (Rank != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Rank);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ID);
      }
      if (Rank != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Rank);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ID);
      }
      if (Rank != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ScheduleRank other) {
      if (other == null) {
        return;
      }
      if (other.ID != 0) {
        ID = other.ID;
      }
      if (other.Rank != 0D) {
        Rank = other.Rank;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ID = input.ReadInt32();
            break;
          }
          case 17: {
            Rank = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code