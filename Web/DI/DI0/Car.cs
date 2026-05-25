using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI0
{
    /// <summary>
    /// 問題点1. Carの役割が複数ある
    /// ・Engineのインスタンスを生成する
    /// ・Engineのメソッドを利用する
    /// 【単一責任の原則】1つのクラスの役割は1つであるべき
    /// 　・Engineのコンストラクタに引数が増えたらCarも書き換えが必要
    /// 　・EngineのStart()の引数が増えたらCarも書き換えが必要
    /// 　役割が多いほど別のクラスの変更が影響するから良くない
    /// </summary>
    internal class Car
    {
        public Engine _engine = new Engine();

        public void Run()
        {
            _engine.Start();
        }
    }
}
