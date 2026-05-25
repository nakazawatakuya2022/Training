using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI1
{
    /// <summary>
    /// 問題点1. Carの役割が複数ある
    /// ・インスタンスを外部で生成しコンストラクタ経由で渡すことにより
    /// 　役割が「Engineのメソッドを利用する」だけになった
    /// 【DI】
    /// 　・内部でインスタンスを生成せず、外部から渡す設計のことを DI という
    /// 
    /// 問題点2. 密結合
    /// 【依存】
    /// 　・CarはEngineが無ければ成り立たない
    /// 　・つまり、CarはEngineに 依存 している
    /// 　・依存自体は悪いことではない
    /// 【密結合】
    /// 　・依存先（Engine）をElectricEngineに差し替えるためには
    /// 　　Carを書き換えなくてはいけない。
    /// 　・依存先の変更により大きな影響を受ける状態を 密結合 という
    /// 　・この密結合が問題
    /// </summary>
    internal class Car
    {
        public Engine _engine;

        public Car(Engine engine)
        {
            _engine = engine;
        }

        public void Run()
        {
            _engine.Start();
        }
    }
}
