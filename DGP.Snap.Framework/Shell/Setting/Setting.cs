﻿
namespace DGP.Snap.Framework.Shell.Setting
{
    /// <summary>
    /// 表示一项设置
    /// </summary>
    public class Setting<T>
    {
        private T _value;
        public T Value { get => this._value; set => this._value = value; }

        public static implicit operator T(Setting<T> setting)
        {
            return setting.Value;
        }
    }
}
