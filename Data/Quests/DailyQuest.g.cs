// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Quests/DailyQuest.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Quests {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Quests/DailyQuest.proto</summary>
  public static partial class DailyQuestReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Quests/DailyQuest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DailyQuestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL0RhdGEvUXVlc3RzL0RhaWx5UXVlc3QucHJvdG8SFlBP",
            "R09Qcm90b3MuRGF0YS5RdWVzdHMiSQoKRGFpbHlRdWVzdBIdChVjdXJyZW50",
            "X3BlcmlvZF9idWNrZXQYASABKAUSHAoUY3VycmVudF9zdHJlYWtfY291bnQY",
            "AiABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.DailyQuest), global::POGOProtos.Data.Quests.DailyQuest.Parser, new[]{ "CurrentPeriodBucket", "CurrentStreakCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DailyQuest : pb::IMessage<DailyQuest> {
    private static readonly pb::MessageParser<DailyQuest> _parser = new pb::MessageParser<DailyQuest>(() => new DailyQuest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DailyQuest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Quests.DailyQuestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyQuest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyQuest(DailyQuest other) : this() {
      currentPeriodBucket_ = other.currentPeriodBucket_;
      currentStreakCount_ = other.currentStreakCount_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyQuest Clone() {
      return new DailyQuest(this);
    }

    /// <summary>Field number for the "current_period_bucket" field.</summary>
    public const int CurrentPeriodBucketFieldNumber = 1;
    private int currentPeriodBucket_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CurrentPeriodBucket {
      get { return currentPeriodBucket_; }
      set {
        currentPeriodBucket_ = value;
      }
    }

    /// <summary>Field number for the "current_streak_count" field.</summary>
    public const int CurrentStreakCountFieldNumber = 2;
    private int currentStreakCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CurrentStreakCount {
      get { return currentStreakCount_; }
      set {
        currentStreakCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DailyQuest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DailyQuest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrentPeriodBucket != other.CurrentPeriodBucket) return false;
      if (CurrentStreakCount != other.CurrentStreakCount) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrentPeriodBucket != 0) hash ^= CurrentPeriodBucket.GetHashCode();
      if (CurrentStreakCount != 0) hash ^= CurrentStreakCount.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CurrentPeriodBucket != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CurrentPeriodBucket);
      }
      if (CurrentStreakCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CurrentStreakCount);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrentPeriodBucket != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurrentPeriodBucket);
      }
      if (CurrentStreakCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurrentStreakCount);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DailyQuest other) {
      if (other == null) {
        return;
      }
      if (other.CurrentPeriodBucket != 0) {
        CurrentPeriodBucket = other.CurrentPeriodBucket;
      }
      if (other.CurrentStreakCount != 0) {
        CurrentStreakCount = other.CurrentStreakCount;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            CurrentPeriodBucket = input.ReadInt32();
            break;
          }
          case 16: {
            CurrentStreakCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
