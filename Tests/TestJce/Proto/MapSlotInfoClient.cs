// **********************************************************************
// This file was generated by a TAF parser!
// TAF version 3.2.2.16 by WSRD Tencent.
// Generated from `SLGMapConfigProto.jce'
// **********************************************************************

using System;
namespace SLGMapConfig
{

    public sealed class MapSlotInfoClient : Wup.Jce.JceStruct
    {
        public int iTerrainLayer = 0;

        public int iTerrainObject = 0;

        public int iTerrainType = 0;

        public override void WriteTo(Wup.Jce.JceOutputStream _os)
        {
            _os.Write(iTerrainLayer, 0);
            _os.Write(iTerrainObject, 1);
            _os.Write(iTerrainType, 2);
        }

        public override void ReadFrom(Wup.Jce.JceInputStream _is)
        {
            iTerrainLayer = (int) _is.Read(iTerrainLayer, 0, false);

            iTerrainObject = (int) _is.Read(iTerrainObject, 1, false);

            iTerrainType = (int) _is.Read(iTerrainType, 2, false);

        }

        public override void Display(System.Text.StringBuilder _os, int _level)
        {
            Wup.Jce.JceDisplayer _ds = new Wup.Jce.JceDisplayer(_os, _level);
            _ds.Display(iTerrainLayer, "iTerrainLayer");
            _ds.Display(iTerrainObject, "iTerrainObject");
            _ds.Display(iTerrainType, "iTerrainType");
        }

    }
}
