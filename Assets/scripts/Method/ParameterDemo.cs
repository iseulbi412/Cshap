using UnityEditor.Experimental;
using UnityEngine;
using static Method.ParameterDemo;
namespace Method
{
    public class ParameterDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //���� ����
            Monster monster1 = new Monster(100, 10);
            Monster.monsterCount++;
            Monster monster2 = new Monster(200, 20);
            Monster.monsterCount++;

            //����
            //MonsterBattle(monster2, monster1);
            monster1.TakeDamage(monster2.atk);
            monster2.TakeDamage(monster1.atk);
            Debug.Log($"monster1 hp: {monster1.hp}, atk: {monster1.atk}");
            Debug.Log($"monster2 hp: {monster2.hp}, atk: {monster2.atk}");
            Debug.Log($"monsterCount: {Monster.monsterCount}");
        }
        //���Ͱ��� 1:1���� ���� 
        void MonsterBattle(Monster atkMonster, Monster defMonster)
        {
            defMonster.hp -= atkMonster.atk;
        }
        
        
    }
    //���͸� �����ϴ��� Ŭ����
    public class Monster
    {
        public static int monsterCount = 0;

        public int hp;
        public int atk;

        //������
        public Monster(int hp, int atk)
        {
            this.hp = hp;
            this.atk = atk;
        }
        public void TakeDamage(int damage)
        {
            this.hp -= damage;
        }

    }
}