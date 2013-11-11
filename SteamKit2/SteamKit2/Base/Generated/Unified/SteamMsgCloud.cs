//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_cloud.steamclient.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetUploadServerInfo_Request")]
  public partial class CCloud_GetUploadServerInfo_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_GetUploadServerInfo_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetUploadServerInfo_Response")]
  public partial class CCloud_GetUploadServerInfo_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_GetUploadServerInfo_Response() {}
    

    private string _server_url = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"server_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string server_url
    {
      get { return _server_url; }
      set { _server_url = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_BeginHTTPUpload_Request")]
  public partial class CCloud_BeginHTTPUpload_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_BeginHTTPUpload_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private uint _file_size = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"file_size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint file_size
    {
      get { return _file_size; }
      set { _file_size = value; }
    }

    private string _filename = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filename
    {
      get { return _filename; }
      set { _filename = value; }
    }

    private string _file_sha = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"file_sha", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string file_sha
    {
      get { return _file_sha; }
      set { _file_sha = value; }
    }

    private bool _is_public = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"is_public", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_public
    {
      get { return _is_public; }
      set { _is_public = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _platforms_to_sync = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(6, Name=@"platforms_to_sync", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> platforms_to_sync
    {
      get { return _platforms_to_sync; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_BeginHTTPUpload_Response")]
  public partial class CCloud_BeginHTTPUpload_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_BeginHTTPUpload_Response() {}
    

    private ulong _ugcid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ugcid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong ugcid
    {
      get { return _ugcid; }
      set { _ugcid = value; }
    }

    private uint _timestamp = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }

    private string _url_host = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"url_host", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string url_host
    {
      get { return _url_host; }
      set { _url_host = value; }
    }

    private string _url_path = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"url_path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string url_path
    {
      get { return _url_path; }
      set { _url_path = value; }
    }

    private bool _use_https = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"use_https", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool use_https
    {
      get { return _use_https; }
      set { _use_https = value; }
    }
    private readonly global::System.Collections.Generic.List<CCloud_BeginHTTPUpload_Response.HTTPHeaders> _request_headers = new global::System.Collections.Generic.List<CCloud_BeginHTTPUpload_Response.HTTPHeaders>();
    [global::ProtoBuf.ProtoMember(6, Name=@"request_headers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CCloud_BeginHTTPUpload_Response.HTTPHeaders> request_headers
    {
      get { return _request_headers; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HTTPHeaders")]
  public partial class HTTPHeaders : global::ProtoBuf.IExtensible
  {
    public HTTPHeaders() {}
    

    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _value = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_CommitHTTPUpload_Request")]
  public partial class CCloud_CommitHTTPUpload_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_CommitHTTPUpload_Request() {}
    

    private bool _transfer_succeeded = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"transfer_succeeded", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool transfer_succeeded
    {
      get { return _transfer_succeeded; }
      set { _transfer_succeeded = value; }
    }

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private string _file_sha = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"file_sha", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string file_sha
    {
      get { return _file_sha; }
      set { _file_sha = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_CommitHTTPUpload_Response")]
  public partial class CCloud_CommitHTTPUpload_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_CommitHTTPUpload_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetFileDetails_Request")]
  public partial class CCloud_GetFileDetails_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_GetFileDetails_Request() {}
    

    private ulong _ugcid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ugcid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong ugcid
    {
      get { return _ugcid; }
      set { _ugcid = value; }
    }

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_UserFile")]
  public partial class CCloud_UserFile : global::ProtoBuf.IExtensible
  {
    public CCloud_UserFile() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _ugcid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ugcid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong ugcid
    {
      get { return _ugcid; }
      set { _ugcid = value; }
    }

    private string _filename = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filename
    {
      get { return _filename; }
      set { _filename = value; }
    }

    private ulong _timestamp = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }

    private uint _file_size = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"file_size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint file_size
    {
      get { return _file_size; }
      set { _file_size = value; }
    }

    private string _url = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string url
    {
      get { return _url; }
      set { _url = value; }
    }

    private ulong _steamid_creator = default(ulong);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"steamid_creator", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid_creator
    {
      get { return _steamid_creator; }
      set { _steamid_creator = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetFileDetails_Response")]
  public partial class CCloud_GetFileDetails_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_GetFileDetails_Response() {}
    

    private CCloud_UserFile _details = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"details", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CCloud_UserFile details
    {
      get { return _details; }
      set { _details = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_EnumerateUserFiles_Request")]
  public partial class CCloud_EnumerateUserFiles_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_EnumerateUserFiles_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private bool _extended_details = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"extended_details", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool extended_details
    {
      get { return _extended_details; }
      set { _extended_details = value; }
    }

    private uint _count = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint count
    {
      get { return _count; }
      set { _count = value; }
    }

    private uint _start_index = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"start_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint start_index
    {
      get { return _start_index; }
      set { _start_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_EnumerateUserFiles_Response")]
  public partial class CCloud_EnumerateUserFiles_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_EnumerateUserFiles_Response() {}
    
    private readonly global::System.Collections.Generic.List<CCloud_UserFile> _files = new global::System.Collections.Generic.List<CCloud_UserFile>();
    [global::ProtoBuf.ProtoMember(1, Name=@"files", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CCloud_UserFile> files
    {
      get { return _files; }
    }
  

    private uint _total_files = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"total_files", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint total_files
    {
      get { return _total_files; }
      set { _total_files = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_Delete_Request")]
  public partial class CCloud_Delete_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_Delete_Request() {}
    

    private string _filename = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filename
    {
      get { return _filename; }
      set { _filename = value; }
    }

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_Delete_Response")]
  public partial class CCloud_Delete_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_Delete_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetClientEncryptionKey_Request")]
  public partial class CCloud_GetClientEncryptionKey_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_GetClientEncryptionKey_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetClientEncryptionKey_Response")]
  public partial class CCloud_GetClientEncryptionKey_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_GetClientEncryptionKey_Response() {}
    

    private byte[] _key = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }

    private int _crc = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"crc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int crc
    {
      get { return _crc; }
      set { _crc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_CDNReport_Notification")]
  public partial class CCloud_CDNReport_Notification : global::ProtoBuf.IExtensible
  {
    public CCloud_CDNReport_Notification() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private string _url = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string url
    {
      get { return _url; }
      set { _url = value; }
    }

    private bool _success = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }

    private uint _http_status_code = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"http_status_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint http_status_code
    {
      get { return _http_status_code; }
      set { _http_status_code = value; }
    }

    private ulong _expected_bytes = default(ulong);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"expected_bytes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong expected_bytes
    {
      get { return _expected_bytes; }
      set { _expected_bytes = value; }
    }

    private ulong _received_bytes = default(ulong);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"received_bytes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong received_bytes
    {
      get { return _received_bytes; }
      set { _received_bytes = value; }
    }

    private uint _duration = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_ExternalStorageTransferReport_Notification")]
  public partial class CCloud_ExternalStorageTransferReport_Notification : global::ProtoBuf.IExtensible
  {
    public CCloud_ExternalStorageTransferReport_Notification() {}
    

    private string _host = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"host", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string host
    {
      get { return _host; }
      set { _host = value; }
    }

    private string _path = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string path
    {
      get { return _path; }
      set { _path = value; }
    }

    private bool _is_upload = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"is_upload", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_upload
    {
      get { return _is_upload; }
      set { _is_upload = value; }
    }

    private bool _success = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }

    private uint _http_status_code = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"http_status_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint http_status_code
    {
      get { return _http_status_code; }
      set { _http_status_code = value; }
    }

    private ulong _bytes_expected = default(ulong);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"bytes_expected", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong bytes_expected
    {
      get { return _bytes_expected; }
      set { _bytes_expected = value; }
    }

    private ulong _bytes_actual = default(ulong);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"bytes_actual", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong bytes_actual
    {
      get { return _bytes_actual; }
      set { _bytes_actual = value; }
    }

    private uint _duration_ms = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"duration_ms", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint duration_ms
    {
      get { return _duration_ms; }
      set { _duration_ms = value; }
    }

    private uint _cellid = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"cellid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cellid
    {
      get { return _cellid; }
      set { _cellid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface ICloud
    {
      CCloud_GetUploadServerInfo_Response GetUploadServerInfo(CCloud_GetUploadServerInfo_Request request);
    CCloud_BeginHTTPUpload_Response BeginHTTPUpload(CCloud_BeginHTTPUpload_Request request);
    CCloud_CommitHTTPUpload_Response CommitHTTPUpload(CCloud_CommitHTTPUpload_Request request);
    CCloud_GetFileDetails_Response GetFileDetails(CCloud_GetFileDetails_Request request);
    CCloud_EnumerateUserFiles_Response EnumerateUserFiles(CCloud_EnumerateUserFiles_Request request);
    CCloud_Delete_Response Delete(CCloud_Delete_Request request);
    CCloud_GetClientEncryptionKey_Response GetClientEncryptionKey(CCloud_GetClientEncryptionKey_Request request);
    NoResponse CDNReport(CCloud_CDNReport_Notification request);
    NoResponse ExternalStorageTransferReport(CCloud_ExternalStorageTransferReport_Notification request);
    
    }
    
    
}
#pragma warning restore 1591
