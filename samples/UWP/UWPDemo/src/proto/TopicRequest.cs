// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace com.tencent.mars.sample.proto {
  
  namespace Proto {
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public static partial class TopicRequest {
    
      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      #endregion
      #region Extensions
      internal static readonly object Descriptor;
      static TopicRequest() {
        Descriptor = null;
      }
      #endregion
      
    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class TopicRequest : pb::GeneratedMessageLite<TopicRequest, TopicRequest.Builder> {
    private TopicRequest() { }
    private static readonly TopicRequest defaultInstance = new TopicRequest().MakeReadOnly();
    private static readonly string[] _topicRequestFieldNames = new string[] { "topic" };
    private static readonly uint[] _topicRequestFieldTags = new uint[] { 10 };
    public static TopicRequest DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TopicRequest DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override TopicRequest ThisMessage {
      get { return this; }
    }
    
    public const int TopicFieldNumber = 1;
    private bool hasTopic;
    private string topic_ = "";
    public string Topic {
      get { return topic_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasTopic) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _topicRequestFieldNames;
      if (hasTopic) {
        output.WriteString(1, field_names[0], Topic);
      }
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasTopic) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Topic);
        }
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasTopic) hash ^= topic_.GetHashCode();
      return hash;
    }
    
    public override bool Equals(object obj) {
      TopicRequest other = obj as TopicRequest;
      if (other == null) return false;
      if (hasTopic != other.hasTopic || (hasTopic && !topic_.Equals(other.topic_))) return false;
      return true;
    }
    
    public override void PrintTo(global::System.IO.TextWriter writer) {
      PrintField("topic", hasTopic, topic_, writer);
    }
    #endregion
    
    public static TopicRequest ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    private TopicRequest MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TopicRequest prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::GeneratedBuilderLite<TopicRequest, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(TopicRequest cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private TopicRequest result;
      
      private TopicRequest PrepareBuilder() {
        if (resultIsReadOnly) {
          TopicRequest original = result;
          result = new TopicRequest();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override TopicRequest MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override TopicRequest DefaultInstanceForType {
        get { return global::com.tencent.mars.sample.proto.TopicRequest.DefaultInstance; }
      }
      
      public override TopicRequest BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessageLite other) {
        if (other is TopicRequest) {
          return MergeFrom((TopicRequest) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(TopicRequest other) {
      return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_topicRequestFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _topicRequestFieldTags[field_ordinal];
            else {
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                return this;
              }
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasTopic = input.ReadString(ref result.topic_);
              break;
            }
          }
        }
        
        return this;
        }
        
        
        public string Topic {
          get { return result.Topic; }
          set { SetTopic(value); }
        }
        public Builder SetTopic(string value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasTopic = true;
          result.topic_ = value;
          return this;
        }
        public Builder ClearTopic() {
          PrepareBuilder();
          result.hasTopic = false;
          result.topic_ = "";
          return this;
        }
      }
      static TopicRequest() {
        object.ReferenceEquals(global::com.tencent.mars.sample.proto.Proto.TopicRequest.Descriptor, null);
      }
    }
    
    #endregion
    
  }
  
  #endregion Designer generated code
