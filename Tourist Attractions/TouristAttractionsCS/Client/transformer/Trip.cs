/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace transformer
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Trip : TBase
  {
    private int _id;
    private string _touristAttraction;
    private string _transportCompany;
    private LocalTime _leavingHour;
    private double _price;
    private int _nrSeats;

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public string TouristAttraction
    {
      get
      {
        return _touristAttraction;
      }
      set
      {
        __isset.touristAttraction = true;
        this._touristAttraction = value;
      }
    }

    public string TransportCompany
    {
      get
      {
        return _transportCompany;
      }
      set
      {
        __isset.transportCompany = true;
        this._transportCompany = value;
      }
    }

    public LocalTime LeavingHour
    {
      get
      {
        return _leavingHour;
      }
      set
      {
        __isset.leavingHour = true;
        this._leavingHour = value;
      }
    }

    public double Price
    {
      get
      {
        return _price;
      }
      set
      {
        __isset.price = true;
        this._price = value;
      }
    }

    public int NrSeats
    {
      get
      {
        return _nrSeats;
      }
      set
      {
        __isset.nrSeats = true;
        this._nrSeats = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool touristAttraction;
      public bool transportCompany;
      public bool leavingHour;
      public bool price;
      public bool nrSeats;
    }

    public Trip() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              TouristAttraction = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              TransportCompany = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Struct) {
              LeavingHour = new LocalTime();
              LeavingHour.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Double) {
              Price = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              NrSeats = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Trip");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (TouristAttraction != null && __isset.touristAttraction) {
        field.Name = "touristAttraction";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TouristAttraction);
        oprot.WriteFieldEnd();
      }
      if (TransportCompany != null && __isset.transportCompany) {
        field.Name = "transportCompany";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TransportCompany);
        oprot.WriteFieldEnd();
      }
      if (LeavingHour != null && __isset.leavingHour) {
        field.Name = "leavingHour";
        field.Type = TType.Struct;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        LeavingHour.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.price) {
        field.Name = "price";
        field.Type = TType.Double;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Price);
        oprot.WriteFieldEnd();
      }
      if (__isset.nrSeats) {
        field.Name = "nrSeats";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(NrSeats);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Trip(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",TouristAttraction: ");
      sb.Append(TouristAttraction);
      sb.Append(",TransportCompany: ");
      sb.Append(TransportCompany);
      sb.Append(",LeavingHour: ");
      sb.Append(LeavingHour== null ? "<null>" : LeavingHour.ToString());
      sb.Append(",Price: ");
      sb.Append(Price);
      sb.Append(",NrSeats: ");
      sb.Append(NrSeats);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
