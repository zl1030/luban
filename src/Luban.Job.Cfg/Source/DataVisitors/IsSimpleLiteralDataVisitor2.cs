using Luban.Job.Cfg.Datas;
using System;
using System.Numerics;

namespace Luban.Job.Cfg.DataVisitors
{
    class IsSimpleLiteralDataVisitor2 : IDataFuncVisitor<bool>
    {
        public static IsSimpleLiteralDataVisitor2 Ins { get; } = new();

        public bool Accept(DBool type)
        {
            return true;
        }

        public bool Accept(DByte type)
        {
            return true;
        }

        public bool Accept(DShort type)
        {
            return true;
        }

        public bool Accept(DFshort type)
        {
            return true;
        }

        public bool Accept(DInt type)
        {
            return true;
        }

        public bool Accept(DFint type)
        {
            return true;
        }

        public bool Accept(DLong type)
        {
            return true;
        }

        public bool Accept(DFlong type)
        {
            return true;
        }

        public bool Accept(DFloat type)
        {
            return true;
        }

        public bool Accept(DDouble type)
        {
            return true;
        }

        public bool Accept(DEnum type)
        {
            return true;
        }

        public bool Accept(DString type)
        {
            return true;
        }

        public bool Accept(DBytes type)
        {
            throw new NotSupportedException();
        }

        public bool Accept(DText type)
        {
            return true;
        }

        public bool Accept(DBean type)
        {
            return false;
        }

        public bool Accept(DArray type)
        {
            return false;
        }

        public bool Accept(DList type)
        {
            return false;
        }

        public bool Accept(DSet type)
        {
            return false;
        }

        public bool Accept(DMap type)
        {
            return false;
        }

        public bool Accept(DVector2 type)
        {
            return true;
        }

        public bool Accept(DVector3 type)
        {
            return true;
        }

        public bool Accept(DVector4 type)
        {
            return true;
        }

        public bool Accept(DDateTime type)
        {
            return true;
        }
    }
}
