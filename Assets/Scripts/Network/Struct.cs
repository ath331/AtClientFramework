// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Struct.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protocol {

  /// <summary>Holder for reflection information generated from Struct.proto</summary>
  public static partial class StructReflection {

    #region Descriptor
    /// <summary>File descriptor for Struct.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StructReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxTdHJ1Y3QucHJvdG8SCFByb3RvY29sGgpFbnVtLnByb3RvIm0KB1Bvc0lu",
            "Zm8SCgoCaWQYASABKAQSCQoBeBgCIAEoAhIJCgF5GAMgASgCEgkKAXoYBCAB",
            "KAISCwoDeWF3GAUgASgCEigKCm1vdmVfU3RhdGUYBiABKA4yFC5Qcm90b2Nv",
            "bC5FTW92ZVN0YXRlImkKCk9iamVjdEluZm8SCgoCaWQYASABKAQSKgoLb2Jq",
            "ZWN0X3R5cGUYAiABKA4yFS5Qcm90b2NvbC5FT2JqZWN0VHlwZRIjCghwb3Nf",
            "aW5mbxgDIAEoCzIRLlByb3RvY29sLlBvc0luZm9CC6oCCFByb3RvY29sYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Protocol.EnumReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.PosInfo), global::Protocol.PosInfo.Parser, new[]{ "Id", "X", "Y", "Z", "Yaw", "MoveState" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.ObjectInfo), global::Protocol.ObjectInfo.Parser, new[]{ "Id", "ObjectType", "PosInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PosInfo : pb::IMessage<PosInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PosInfo> _parser = new pb::MessageParser<PosInfo>(() => new PosInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PosInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.StructReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PosInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PosInfo(PosInfo other) : this() {
      id_ = other.id_;
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      yaw_ = other.yaw_;
      moveState_ = other.moveState_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PosInfo Clone() {
      return new PosInfo(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private ulong id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 2;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 3;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 4;
    private float z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "yaw" field.</summary>
    public const int YawFieldNumber = 5;
    private float yaw_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Yaw {
      get { return yaw_; }
      set {
        yaw_ = value;
      }
    }

    /// <summary>Field number for the "move_State" field.</summary>
    public const int MoveStateFieldNumber = 6;
    private global::Protocol.EMoveState moveState_ = global::Protocol.EMoveState.MoveStateNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Protocol.EMoveState MoveState {
      get { return moveState_; }
      set {
        moveState_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PosInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PosInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Yaw, other.Yaw)) return false;
      if (MoveState != other.MoveState) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0UL) hash ^= Id.GetHashCode();
      if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
      if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
      if (Z != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
      if (Yaw != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Yaw);
      if (MoveState != global::Protocol.EMoveState.MoveStateNone) hash ^= MoveState.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Id);
      }
      if (X != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Y);
      }
      if (Z != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Z);
      }
      if (Yaw != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Yaw);
      }
      if (MoveState != global::Protocol.EMoveState.MoveStateNone) {
        output.WriteRawTag(48);
        output.WriteEnum((int) MoveState);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Id);
      }
      if (X != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Y);
      }
      if (Z != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Z);
      }
      if (Yaw != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Yaw);
      }
      if (MoveState != global::Protocol.EMoveState.MoveStateNone) {
        output.WriteRawTag(48);
        output.WriteEnum((int) MoveState);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Id);
      }
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (Z != 0F) {
        size += 1 + 4;
      }
      if (Yaw != 0F) {
        size += 1 + 4;
      }
      if (MoveState != global::Protocol.EMoveState.MoveStateNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MoveState);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PosInfo other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0UL) {
        Id = other.Id;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.Z != 0F) {
        Z = other.Z;
      }
      if (other.Yaw != 0F) {
        Yaw = other.Yaw;
      }
      if (other.MoveState != global::Protocol.EMoveState.MoveStateNone) {
        MoveState = other.MoveState;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadUInt64();
            break;
          }
          case 21: {
            X = input.ReadFloat();
            break;
          }
          case 29: {
            Y = input.ReadFloat();
            break;
          }
          case 37: {
            Z = input.ReadFloat();
            break;
          }
          case 45: {
            Yaw = input.ReadFloat();
            break;
          }
          case 48: {
            MoveState = (global::Protocol.EMoveState) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadUInt64();
            break;
          }
          case 21: {
            X = input.ReadFloat();
            break;
          }
          case 29: {
            Y = input.ReadFloat();
            break;
          }
          case 37: {
            Z = input.ReadFloat();
            break;
          }
          case 45: {
            Yaw = input.ReadFloat();
            break;
          }
          case 48: {
            MoveState = (global::Protocol.EMoveState) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ObjectInfo : pb::IMessage<ObjectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ObjectInfo> _parser = new pb::MessageParser<ObjectInfo>(() => new ObjectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ObjectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.StructReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObjectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObjectInfo(ObjectInfo other) : this() {
      id_ = other.id_;
      objectType_ = other.objectType_;
      posInfo_ = other.posInfo_ != null ? other.posInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObjectInfo Clone() {
      return new ObjectInfo(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private ulong id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "object_type" field.</summary>
    public const int ObjectTypeFieldNumber = 2;
    private global::Protocol.EObjectType objectType_ = global::Protocol.EObjectType.ObjectTypeNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Protocol.EObjectType ObjectType {
      get { return objectType_; }
      set {
        objectType_ = value;
      }
    }

    /// <summary>Field number for the "pos_info" field.</summary>
    public const int PosInfoFieldNumber = 3;
    private global::Protocol.PosInfo posInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Protocol.PosInfo PosInfo {
      get { return posInfo_; }
      set {
        posInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ObjectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ObjectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (ObjectType != other.ObjectType) return false;
      if (!object.Equals(PosInfo, other.PosInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0UL) hash ^= Id.GetHashCode();
      if (ObjectType != global::Protocol.EObjectType.ObjectTypeNone) hash ^= ObjectType.GetHashCode();
      if (posInfo_ != null) hash ^= PosInfo.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Id);
      }
      if (ObjectType != global::Protocol.EObjectType.ObjectTypeNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ObjectType);
      }
      if (posInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PosInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Id);
      }
      if (ObjectType != global::Protocol.EObjectType.ObjectTypeNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ObjectType);
      }
      if (posInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PosInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Id);
      }
      if (ObjectType != global::Protocol.EObjectType.ObjectTypeNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ObjectType);
      }
      if (posInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PosInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ObjectInfo other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0UL) {
        Id = other.Id;
      }
      if (other.ObjectType != global::Protocol.EObjectType.ObjectTypeNone) {
        ObjectType = other.ObjectType;
      }
      if (other.posInfo_ != null) {
        if (posInfo_ == null) {
          PosInfo = new global::Protocol.PosInfo();
        }
        PosInfo.MergeFrom(other.PosInfo);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadUInt64();
            break;
          }
          case 16: {
            ObjectType = (global::Protocol.EObjectType) input.ReadEnum();
            break;
          }
          case 26: {
            if (posInfo_ == null) {
              PosInfo = new global::Protocol.PosInfo();
            }
            input.ReadMessage(PosInfo);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadUInt64();
            break;
          }
          case 16: {
            ObjectType = (global::Protocol.EObjectType) input.ReadEnum();
            break;
          }
          case 26: {
            if (posInfo_ == null) {
              PosInfo = new global::Protocol.PosInfo();
            }
            input.ReadMessage(PosInfo);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
