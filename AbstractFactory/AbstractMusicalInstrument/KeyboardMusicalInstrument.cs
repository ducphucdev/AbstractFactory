using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractMusicalInstrument
{
    // KHAI BÁO ABSTRACT CLASS KẾ THỪA INTERFACE ĐÃ TẠO TRƯỚC ĐÓ - KHÔNG IMPLEMENT INTERFACE => ĐỂ CHO CÁC LỚP KẾ THỪA THỰC HIỆN
    abstract class KeyboardMusicalInstrument : IMusicalInstrument
    {
        public abstract string GetNameMusicalInstrument();
    }
}
