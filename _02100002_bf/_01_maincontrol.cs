using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02100002_bf {
    public static class _01_maincontrol {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.LimitSpawnNpcCount(limitCount: 0, desc: "몬스터 스폰 제한을 끕니다.");
                context.SetInteractObject(arg1: new int[] {10001239}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001240}, arg2: 0);
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215,
                        3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315,
                        3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415,
                        3416, 3417, 3418, 3419, 3420, 3421, 3422, 3423
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515,
                        3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {900});
                context.DestroyMonster(arg1: new int[] {1000, 2000});
                context.CreateWidget(arg1: "RainbowMonster");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715,
                        3716, 3717, 3718, 3719, 3720, 3721, 3722, 3723, 3724, 3725, 3726, 3727, 3728, 3729, 3730, 3731,
                        3732, 3733, 3734, 3735, 3736, 3737, 3738, 3739, 3740, 3741, 3742, 3743, 3744, 3745, 3746, 3747,
                        3748, 3749, 3750, 3751, 3752, 3753, 3754, 3755, 3756, 3757, 3758, 3759, 3760, 3761, 3762, 3763,
                        3764, 3765, 3766, 3767, 3768, 3769, 3770, 3771, 3772, 3773, 3774, 3775, 3776, 3777, 3778, 3779,
                        3780, 3781, 3782, 3783, 3784, 3785, 3786, 3787, 3788, 3789, 3790, 3791, 3792, 3793, 3794, 3795,
                        3796, 3797, 3798, 3799
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815,
                        3816, 3817, 3818, 3819
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {900}, arg2: false);
                context.LimitSpawnNpcCount(limitCount: 200);
                context.WidgetAction(arg1: "RainbowMonster", arg2: "CreateGroup", widgetArgNum: 1,
                    arg3: "34000122,34000123,34000124,34000142");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "CreateGroup", widgetArgNum: 2,
                    arg3: "34000128,34000129,34000130,34000143");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "CreateGroup", widgetArgNum: 3,
                    arg3: "34000125,34000126,34000127,34000144");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "CreateGroup", widgetArgNum: 4,
                    arg3: "34000131,34000132,34000133,34000145");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "CreateGroup", widgetArgNum: 5,
                    arg3: "34000134,34000135,34000136,34000146");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "SetKillerNpc", arg3: "34000141",
                    desc: "34000141 npc가 죽인 몬스터만 스코어에 반영");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "SetLoseScoreTick", widgetArgNum: 60000,
                    desc: "60초마다 감점");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "SetBadNpc", arg3: "34000121,34000137",
                    desc: "해당 NPC가 킬러에게 죽으면 모든 게이지 감소");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "SetBadNpcScore", arg3: "2-5",
                    desc: "2~5칸 게이지가 떨어진다");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "SetBadNpcSoundKey",
                    arg3: "GuildRaid_RainbowSlimeFactory_ScreenWarning_01", desc: "게이지가 떨어질때 플레이할 사운드");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMaxGaugePattern_Random(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxGaugePattern_Random : TriggerState {
            internal StateMaxGaugePattern_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "RainbowMonster", arg2: "InitRandomMaxScore",
                    arg3: "120,120,140,140,160,160");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "InitScoreMesh", widgetArgNum: 1, arg3: "3100");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "InitScoreMesh", widgetArgNum: 2, arg3: "3200");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "InitScoreMesh", widgetArgNum: 3, arg3: "3300");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "InitScoreMesh", widgetArgNum: 4, arg3: "3500");
                context.WidgetAction(arg1: "RainbowMonster", arg2: "InitScoreMesh", widgetArgNum: 5, arg3: "3400");
            }

            public override void Execute() {
                if (true) {
                    context.State =
                        new _checkuser10_guildraid.StateCheckUser10_GuildRaid(context,
                            new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateShowCaption01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01 : TriggerState {
            internal StateShowCaption01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__0$");
                context.SetSkip(arg1: "ShowCaption01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateShowCaption01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01Skip : TriggerState {
            internal StateShowCaption01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateShowCaption02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02 : TriggerState {
            internal StateShowCaption02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__1$");
                context.SetSkip(arg1: "ShowCaption02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateShowCaption02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02Skip : TriggerState {
            internal StateShowCaption02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateShowCaption03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption03 : TriggerState {
            internal StateShowCaption03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 900, arg2: true);
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__2$");
                context.SetSkip(arg1: "ShowCaption03Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateShowCaption03Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption03Skip : TriggerState {
            internal StateShowCaption03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateShowCaption04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption04 : TriggerState {
            internal StateShowCaption04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__3$");
                context.SetSkip(arg1: "ShowCaption04Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateShowCaption04Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption04Skip : TriggerState {
            internal StateShowCaption04Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateShowCaption05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption05 : TriggerState {
            internal StateShowCaption05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 902, arg2: true);
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__4$");
                context.SetSkip(arg1: "ShowCaption05Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateShowCaption05Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption05Skip : TriggerState {
            internal StateShowCaption05Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraReset(interpolationTime: 1f);
                context.SetUserValue(triggerID: 2, key: "GuideNpcSpawn", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCloseCaptionSetting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCloseCaptionSetting : TriggerState {
            internal StateCloseCaptionSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CloseCinematic();
                context.SetMesh(
                    arg1: new int[] {
                        3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715,
                        3716, 3717, 3718, 3719, 3720, 3721, 3722, 3723, 3724, 3725, 3726, 3727, 3728, 3729, 3730, 3731,
                        3732, 3733, 3734, 3735, 3736, 3737, 3738, 3739, 3740, 3741, 3742, 3743, 3744, 3745, 3746, 3747,
                        3748, 3749, 3750, 3751, 3752, 3753, 3754, 3755, 3756, 3757, 3758, 3759, 3760, 3761, 3762, 3763,
                        3764, 3765, 3766, 3767, 3768, 3769, 3770, 3771, 3772, 3773, 3774, 3775, 3776, 3777, 3778, 3779,
                        3780, 3781, 3782, 3783, 3784, 3785, 3786, 3787, 3788, 3789, 3790, 3791, 3792, 3793, 3794, 3795,
                        3796, 3797, 3798, 3799
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815,
                        3816, 3817, 3818, 3819
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide01 : TriggerState {
            internal StateGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99, key: "PortalOn", value: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$02100002_BF__01_MAINCONTROL__5$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateGuide02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide02 : TriggerState {
            internal StateGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$02100002_BF__01_MAINCONTROL__6$", arg3: new int[] {3000});
                context.SetInteractObject(arg1: new int[] {10001239}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001239}, arg2: 0)) {
                    context.State = new StateGuide03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide03 : TriggerState {
            internal StateGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "GuildRaid_RainbowSlimeFactory_MachineOn_01");
                context.SetEventUI(arg1: 1, arg2: "$02100002_BF__01_MAINCONTROL__7$", arg3: new int[] {2000});
                context.SetInteractObject(arg1: new int[] {10001239}, arg2: 0);
                context.SetUserValue(triggerID: 11, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerID: 12, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerID: 13, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerID: 14, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerID: 15, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerID: 21, key: "ActivateHolder", value: 1);
                context.SetUserValue(triggerID: 22, key: "ActivateHolder", value: 1);
                context.SetUserValue(triggerID: 23, key: "ActivateHolder", value: 1);
                context.SetUserValue(triggerID: 24, key: "ActivateHolder", value: 1);
                context.SetUserValue(triggerID: 25, key: "ActivateHolder", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTimmerStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTimmerStart : TriggerState {
            internal StateTimmerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99, key: "MissionStart", value: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetTimer(arg1: "10000", arg2: 600, arg3: true, arg4: true, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    context.State = new StateEnableCheckOutput(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnableCheckOutput : TriggerState {
            internal StateEnableCheckOutput(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$02100002_BF__01_MAINCONTROL__8$", arg3: new int[] {3000});
                context.SetInteractObject(arg1: new int[] {10001240}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001240}, arg2: 0)) {
                    context.State = new StateCheckSuccess(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10000")) {
                    context.State = new StateMissionFail(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 11, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerID: 12, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerID: 13, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerID: 14, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerID: 15, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerID: 21, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerID: 22, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerID: 23, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerID: 24, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerID: 25, key: "DungeonQuit", value: 1);
                context.DestroyMonster(arg1: new int[] {900});
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10001234}, arg2: 0);
            }
        }

        private class StateCheckSuccess : TriggerState {
            internal StateCheckSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "RainbowMonster", arg2: "IsMissionSuccess", arg3: "19-21")) {
                    context.State = new StateHappyEndingStart(context);
                    return;
                }

                if (!context.WidgetCondition(arg1: "RainbowMonster", arg2: "IsMissionSuccess", arg3: "19-21")) {
                    context.State = new StateBadEndingStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBadEndingStart : TriggerState {
            internal StateBadEndingStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 909, arg2: true);
                context.PlaySystemSoundInBox(arg2: "GuildRaid_RainbowSlimeFactory_Result_01");
                context.MoveUser(arg1: 02100002, arg2: 2, arg3: 9901);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBadEndingSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBadEndingSpawn : TriggerState {
            internal StateBadEndingSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 908, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateBadEndingEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBadEndingEnd : TriggerState {
            internal StateBadEndingEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateMissionFail(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 9902, arg2: "trigger", arg3: "MakeMutantKingSlime");
            }
        }

        private class StateHappyEndingStart : TriggerState {
            internal StateHappyEndingStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 909, arg2: true);
                context.PlaySystemSoundInBox(arg2: "GuildRaid_RainbowSlimeFactory_Result_01");
                context.MoveUser(arg1: 02100002, arg2: 2, arg3: 9901);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateHappyEndingSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHappyEndingSpawn : TriggerState {
            internal StateHappyEndingSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 908, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.CreateMonster(arg1: new int[] {1000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateHappyEndingEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHappyEndingEnd : TriggerState {
            internal StateHappyEndingEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateDungeonSuccess(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 9902, arg2: "trigger", arg3: "MakeRainbowKingSlime");
            }
        }

        private class StateDungeonSuccess : TriggerState {
            internal StateDungeonSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetAchievement(arg1: 9902, arg2: "trigger", arg3: "Find02100002");
                context.SetEventUI(arg1: 7, arg2: "$02100002_BF__01_MAINCONTROL__10$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateExitPortalOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMissionFail : TriggerState {
            internal StateMissionFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "10000");
                context.SetEventUI(arg1: 5, arg2: "$02100002_BF__01_MAINCONTROL__9$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new StateDungeonFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonFail : TriggerState {
            internal StateDungeonFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonFail();
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateExitPortalOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateExitPortalOn : TriggerState {
            internal StateExitPortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetUserValue(triggerID: 99, key: "DungeonClear", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}