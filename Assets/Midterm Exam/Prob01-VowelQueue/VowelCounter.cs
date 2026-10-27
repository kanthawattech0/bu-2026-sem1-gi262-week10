using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MidtermExam.Prob01
{
    public class VowelCounter
    {
        /// <summary>
        /// ข้อ 01: นับจำนวนสระภาษาอังกฤษตัวพิมพ์เล็กในคิว โดยใช้หลัก FIFO
        /// (สมาชิกที่เข้าก่อนออกก่อน) และรักษาสมาชิกกับลำดับของคิวเดิม
        /// </summary>
        /// <param name="alphabets">
        /// [TestCase(new string[] { }, 0)]
        [TestCase(new[] { "a" }, 1)]
        [TestCase(new[] { "a", "e", "i", "o", "u" }, 5)]
        [TestCase(new[] { "a", "b", "e", "c", "i", "d", "o", "u" }, 5)]
        [TestCase(new[] { "b", "c", "d", "f" }, 0)]
        [TestCase(new[] { "a", "a", "a", "e", "e" }, 5)]
        [TestCase(new[] { "A", null, "ae", "", " ", "u" }, 1)]
        /// คิวข้อความที่ต้องการตรวจ นับเฉพาะ "a", "e", "i", "o", "u" และนับตัวซ้ำทุกตัว
        /// ข้อความอื่น เช่น "A", "ae", ข้อความว่าง และสมาชิก null ไม่นับเป็นสระ
        /// </param>
        /// <returns>จำนวนสระทั้งหมด หรือ 0 เมื่อคิวเป็น null หรือไม่มีสมาชิก</returns>
        /// <remarks>
        /// ตัวแปร Queue<string> alphabets หลังจากจบ function จะต้องยังคงข้อมูลให้เหมือนเดิมทั้งจำนวนและลำดับ
        /// HINT: อ่านข้อมูลด้วย Dequeue() และใส่กลับด้วย Enqueue() ในคิวที่รับมา
        /// ตัวอย่าง: ["a", "b", "e", "a"] จะต้อง return 3 
        /// และคิวหลังเรียกยังเป็น ["a", "b", "e", "a"] เหมือนเดิม
        /// </remarks>
        public int AS01_CountVowels(Queue<string> alphabets)
        {

        
        
            throw new NotImplementedException();
        }
    }
}
