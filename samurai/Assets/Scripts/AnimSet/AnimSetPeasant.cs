using UnityEngine;
public class AnimSetPeasant : AnimSet
    protected AnimAttackData AnimAttacksSwordL;
    
        AnimAttacksSwordL = new AnimAttackData("attackPeasant", null, 0.8f, 0.68f, 0.55f, 0.75f, 0.8f, 5, 20, 1, CriticalHitType.None, 0, false, false, false, false);		

        anims.wrapMode = WrapMode.Once;

        anims["idle"].layer = 0;
        anims["idleSword"].layer = 0;
        anims["runSwordBackward"].layer = 0;
        anims["walk"].layer = 0;
        anims["combatMoveB"].layer = 0;
        anims["combatMoveR"].layer = 0;
        anims["combatMoveL"].layer = 0;
        anims["rotationLeft"].layer = 0;
        anims["rotationRight"].layer = 0;
        
        anims["death01"].layer = 2;
        anims["death02"].layer = 2;
        anims["injuryFront01"].layer = 1;
        anims["injuryFront02"].layer = 1;
        anims["injuryFront03"].layer = 1;
        anims["injuryFront04"].layer = 1;

        anims["attackPeasant"].layer = 0;
        anims["attackPeasant"].speed = 1.1f;

 
	}

    public override string GetIdleActionAnim(WeaponType weapon, WeaponState weaponState)
    {
        if(weapon == WeaponType.Katana)
            return "idleTount";

        return "idle";
    }

    public override string GetMoveAnim(MotionType motion, MoveType move, WeaponType weapon, WeaponState weaponState)
                return "walk";
            if (motion == MotionType.WALK)
            {
                if (move == MoveType.FORWARD)
                    return "combatMoveF";
                else if (move == MoveType.BACKWARD)
                    return "combatMoveB";
                else if (move == MoveType.RIGHTWARD)
                    return "combatMoveR";
                else
                    return "combatMoveL";
            }
            else
            {
                if (move == MoveType.FORWARD)
                    return "runSword";
                else if (move == MoveType.BACKWARD)
                    return "runSwordBackward";
            }

        return "idle";

    public override string GetRotateAnim(MotionType motionType, RotationType rotationType)
    {
        if (motionType == MotionType.BLOCK)
        {
            if (rotationType == RotationType.LEFT)
                return "blockStepLeft";

            return "blockStepRight";
        }

        if (rotationType == RotationType.LEFT)
            return "rotationLeft";

        return "rotationRight";
    }

        return "idle";


    public override AnimAttackData GetFirstAttackAnim(WeaponType weapom, AttackType attackType)
    {
        return AnimAttacksSwordL;
    }  

    public override string GetInjuryAnim(WeaponType weapon, DamageType type)
    {
        string[] anims = { "injuryFront01", "injuryFront02", "injuryFront03", "injuryFront04"};

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