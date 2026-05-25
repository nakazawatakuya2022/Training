using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2
{
    /// <summary>
    /// 
    /// 問題点2. 密結合
    /// 【疎結合】
    /// 　・依存先をEngine（具象クラス）からIEngine（インターフェース）に変更
    /// 　・EngineからElectricEngineに差し替えてもCarは書き換えなくていい
    /// 　・依存先の変更の影響が少ない状態を 疎結合 という
    /// </summary>
    internal class Car
    {
        public IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void Run()
        {
            _engine.Start();
        }
    }
}
