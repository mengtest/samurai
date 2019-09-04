using UnityEngine;
using System.Collections;


public enum HardwareType
{
    iPhone3G = 0,
    iPhone4G = 1,
    iPad = 2,
    Max = 3,
}

public enum WeaponType 
{
	NONE = -1,
	KATANA = 0,
	BODY,
    BOW,
	MAX,
}

public enum BlockState
{
    NONE = -1,
    START = 0,          // ��ʽ
    HOLD,               // ����
    END,                // ��ʽ
    BLOCK_SUCCESS,      // �񵲳ɹ�
    BLOCK_FAIL,         // ��ʧ��
}

public enum KnockdownState
{
    None = -1,
    Down = 0,
    Loop,
    Up,
    Fatality,
}

public enum WeaponState
{
    NOT_IN_HANDS,
	IN_HAND,
	//Attacking,
	//Reloading,
	//Empty,
}

public enum AttackType
{
	NONE = -1,
	X = 0,
	O = 1,
    BOSS_BASH = 2,  // ��ʱ����
    FATALITY = 3,   // һ����ɱ������Ե��ص��˵���ɱ��
    COUNTER = 4,    // ����
    BERSERK = 5,    // ����
	MAX = 6,
}
    
public enum AgentType
{
	NONE = -1,
    SWORD_MAN = 0,
    SWORD_MAN_LOW,
    PEASANT,
    PEASANT_LOW,
    DOUBLE_SWORDS_MAN,
    BOW_MAN,    
    MINI_BOSS01,    
    BOSS_OROCHI,
	NPC_MAX,
    PLAYER,
    AI_PLAYER,
}

public enum GameState
{
	MainMenu,
	IngameMenu,
	Game,
	SaleScreen,
    Tutorial,
    Shop,
    Pause,
}

public enum GameType
{
	SinglePlayer,
    ChapterOnly,
	Survival,
    FirstTimeTutorial,
    Tutorial,
    SaleScreen,
}

public enum GameDifficulty
{
    Easy,
	Normal,
	Hard,
}

public enum DamageResultType
{
    NONE,
    INJURY,
    KNOCK_DOWN,
    DEATH,
}

public enum DamageType
{
    NONE,
    FRONT,
    BACK,
    //BREAK_BLOCK, // �Ʒ�
    IN_KNOCK_DOWN,    
}

public enum CriticalHitType
{
    NONE,
    VERTICAL,
	HORIZONTAL,
}

public enum ComboLevel
{
	One = 1,
	Two = 2,
    Three = 3,
    Max = 3
}

public enum ComboLevelPrice
{
    One = 0,
    Two = 1000,
    Three = 2000
}

public enum SwordLevel
{
    One = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Max = 5
}

public enum SwordLevelPrice
{
    One = 0,
    Two = 1000,
    Three = 1500,
    Four = 2000,
    Five = 3000,
}

public enum HealthLevel
{
    One = 1,
    Two = 2,
    Three = 3,
    Max = 3
}

public enum HealtLevelPrice
{
    One = 0,
    Two = 1500,
    Three = 3000,
}

public enum RotationType
{
    LEFT,
    RIGHT
}

public enum MotionType
{
	NONE,
	WALK,
	RUN,
    SPRINT,
    ROLL,
    ATTACK,
    BLOCK,
    BLOCKING_ATTACK,
    INJURY,    
    DEATH,
    KNOCK_DOWN,
    ANIMATION_DRIVE
}

public enum MoveType
{
    NONE,
    FORWARD,
    BACKWARD,
    LEFTWARD,
    RIGHTWARD,
}

public enum LookType
{
    None,
    TrackTarget,
}


public enum EventTypes
{
    NONE,
    //ENEMYSTEP,
    //ENEMYSEE,
    //ENEMYLOST,
    HIT,
    DEAD,
    //IMINPAIN,
    BLOCK_BROKEN,    // �����Ʒ�
    KNOCKDOWN,
    //FriendInjured,
}


public enum Direction
{
    Forward,
    Backward,
    Left,
    Right,
    Up,
    Down
}

public enum BlockResult
{
    NONE = 0,
    SUCCESS,
    FAIL,
}

public enum ComboType
{
    NONE = 0,
    RAISE_WAVE,         // XXXXO �˷������٣�
    HALF_MOON,          // OOOXX ���£��Ʒ���
    CLOUD_CUT,          // OOXXX ���У�������
    WALKING_DEATH,      // XXOXX ̤����������
    CRASH_GENERAL,      // OXOOO �ƽ����ػ���Ⱥ�ˣ�
    FLYING_DRAGON,      // XOOXX ����
        
    MULTI_SWORDS,       // N����
    WHIRL,              // ����ն
    COUNTER,            // ����
    ATTACK_ROLL,        // ���
    JUMP_KILL,          // ��ɱ
}