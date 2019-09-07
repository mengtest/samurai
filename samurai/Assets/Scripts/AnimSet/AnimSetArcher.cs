using UnityEngine;
public class AnimSetArcher : AnimSet
    protected AnimAttackData AnimAttacksBow;

        anims["idle"].layer = 0;
        anims["idleBow"].layer = 0;
        anims["combatMoveB"].layer = 0;
        anims["combatMoveR"].layer = 0;
        anims["combatMoveL"].layer = 0;
        anims["rotateLeft"].layer = 0;
        anims["rotateRight"].layer = 0;
        
        anims["death01"].layer = 2;
        anims["death02"].layer = 2;
        anims["injuryFront"].layer = 1;
        anims["injuryBack"].layer = 1;

        anims["bowFire"].layer = 0;
 

        anims["knockdown"].layer = 0;
        anims["knockdownLoop"].layer = 0;
        anims["knockdownUp"].layer = 0;
        anims["knockdownDeath"].layer = 0;
	}

    public override string GetIdleActionAnim(WeaponType weapon, WeaponState weaponState)
    {
        Debug.LogError("unssupported !!");

        if(weapon == WeaponType.KATANA)
            return "idleTount";

        return "idle";
    }

    public override string GetMoveAnim(MotionType motion, MoveType move, WeaponType weapon, WeaponState weaponState)
            if (move == MoveType.FORWARD)
                return "combatMoveF";
            else if (move == MoveType.BACKWARD)
                return "combatMoveB";
            else if (move == MoveType.RIGHTWARD)
                return "combatMoveR";
            else
                return "combatMoveL";
        }
    }

    public override string GetRotateAnim(MotionType motionType, RotationType rotationType)
    {
        if (rotationType == RotationType.LEFT)
            return "rotateLeft";

        return "rotateRight";
    }

        return "idle";


    public override AnimAttackData GetFirstAttackAnim(WeaponType weapom, OrderAttackType attackType)
    {
        return AnimAttacksBow;
    }


    public override string GetInjuryAnim(WeaponType weapon, DamageType type)
    {

        if(type == DamageType.BACK)
            return "injuryBack";

        string[] anims = { "injuryFront",};

        return anims[Random.Range(0, anims.Length)];
    }

    public override string GetDeathAnim(WeaponType weapon, DamageType type)
    {
        string[] anims = { "death01", "death02"};

        return anims[Random.Range(0, 100) % anims.Length];
    }


    public override string GetKnockdowAnim(KnockdownState state, WeaponType weapon)
    {
        switch (state)
        {
            case KnockdownState.Down:
                return "knockdown";
            case KnockdownState.Loop:
                return "knockdownLoop";
            case KnockdownState.Up:
                return "knockdownUp";
            case KnockdownState.Fatality:
                return "knockdownDeath";
            default:
                return "";
        }
    }