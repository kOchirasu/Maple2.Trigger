using Maple2.Trigger._dungeon_common;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02100002_bf {
    public static class _01_maincontrol {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.LimitSpawnNpcCount(limitCount: 0); // Monster 스폰 제한을 끕니다.
                context.SetInteractObject(interactIds: new []{10001239, 10001240}, state: 0);
                context.SetMesh(triggerIds: new []{3000, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419, 3420, 3421, 3422, 3423, 3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{900, 1000, 2000});
                context.CreateWidget(type: WidgetType.RainbowMonster);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716, 3717, 3718, 3719, 3720, 3721, 3722, 3723, 3724, 3725, 3726, 3727, 3728, 3729, 3730, 3731, 3732, 3733, 3734, 3735, 3736, 3737, 3738, 3739, 3740, 3741, 3742, 3743, 3744, 3745, 3746, 3747, 3748, 3749, 3750, 3751, 3752, 3753, 3754, 3755, 3756, 3757, 3758, 3759, 3760, 3761, 3762, 3763, 3764, 3765, 3766, 3767, 3768, 3769, 3770, 3771, 3772, 3773, 3774, 3775, 3776, 3777, 3778, 3779, 3780, 3781, 3782, 3783, 3784, 3785, 3786, 3787, 3788, 3789, 3790, 3791, 3792, 3793, 3794, 3795, 3796, 3797, 3798, 3799, 3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815, 3816, 3817, 3818, 3819}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{900}, arg2: false);
                context.LimitSpawnNpcCount(limitCount: 200);
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "CreateGroup", widgetArgType: 1, args: "34000122,34000123,34000124,34000142");
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "CreateGroup", widgetArgType: 2, args: "34000128,34000129,34000130,34000143");
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "CreateGroup", widgetArgType: 3, args: "34000125,34000126,34000127,34000144");
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "CreateGroup", widgetArgType: 4, args: "34000131,34000132,34000133,34000145");
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "CreateGroup", widgetArgType: 5, args: "34000134,34000135,34000136,34000146");
                // 34000141 npc가 죽인 Monster만 스코어에 반영
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "SetKillerNpc", args: "34000141");
                // 60초마다 감점
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "SetLoseScoreTick", widgetArgType: 60000);
                // 해당 NPC가 킬러에게 죽으면 모든 게이지 감소
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "SetBadNpc", args: "34000121,34000137");
                // 2~5칸 게이지가 떨어진다
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "SetBadNpcScore", args: "2-5");
                // 게이지가 떨어질때 플레이할 사운드
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "SetBadNpcSoundKey", args: "GuildRaid_RainbowSlimeFactory_ScreenWarning_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMaxGaugePattern_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxGaugePattern_Random : TriggerState {
            internal StateMaxGaugePattern_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "InitRandomMaxScore", args: "120,120,140,140,160,160");
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "InitScoreMesh", widgetArgType: 1, args: "3100");
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "InitScoreMesh", widgetArgType: 2, args: "3200");
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "InitScoreMesh", widgetArgType: 3, args: "3300");
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "InitScoreMesh", widgetArgType: 4, args: "3500");
                context.WidgetAction(type: WidgetType.RainbowMonster, name: "InitScoreMesh", widgetArgType: 5, args: "3400");
            }

            public override TriggerState? Execute() {
                return new _checkuser10_guildraid.StateCheckUser10_GuildRaid(context, new StateDungeonStart(context));
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateShowCaption01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01 : TriggerState {
            internal StateShowCaption01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__0$");
                context.SetSkip(state: new StateShowCaption01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateShowCaption01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01Skip : TriggerState {
            internal StateShowCaption01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateShowCaption02(context);
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02 : TriggerState {
            internal StateShowCaption02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__1$");
                context.SetSkip(state: new StateShowCaption02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateShowCaption02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02Skip : TriggerState {
            internal StateShowCaption02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateShowCaption03(context);
            }

            public override void OnExit() { }
        }

        private class StateShowCaption03 : TriggerState {
            internal StateShowCaption03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 900, enabled: true);
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__2$");
                context.SetSkip(state: new StateShowCaption03Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateShowCaption03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption03Skip : TriggerState {
            internal StateShowCaption03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShowCaption04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption04 : TriggerState {
            internal StateShowCaption04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__3$");
                context.SetSkip(state: new StateShowCaption04Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateShowCaption04Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption04Skip : TriggerState {
            internal StateShowCaption04Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateShowCaption05(context);
            }

            public override void OnExit() { }
        }

        private class StateShowCaption05 : TriggerState {
            internal StateShowCaption05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 902, enabled: true);
                context.SetCinematicIntro(text: "$02100002_BF__01_MAINCONTROL__4$");
                context.SetSkip(state: new StateShowCaption05Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateShowCaption05Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption05Skip : TriggerState {
            internal StateShowCaption05Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraReset(interpolationTime: 1f);
                context.SetUserValue(triggerId: 2, key: "GuideNpcSpawn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCloseCaptionSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCloseCaptionSetting : TriggerState {
            internal StateCloseCaptionSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CloseCinematic();
                context.SetMesh(triggerIds: new []{3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716, 3717, 3718, 3719, 3720, 3721, 3722, 3723, 3724, 3725, 3726, 3727, 3728, 3729, 3730, 3731, 3732, 3733, 3734, 3735, 3736, 3737, 3738, 3739, 3740, 3741, 3742, 3743, 3744, 3745, 3746, 3747, 3748, 3749, 3750, 3751, 3752, 3753, 3754, 3755, 3756, 3757, 3758, 3759, 3760, 3761, 3762, 3763, 3764, 3765, 3766, 3767, 3768, 3769, 3770, 3771, 3772, 3773, 3774, 3775, 3776, 3777, 3778, 3779, 3780, 3781, 3782, 3783, 3784, 3785, 3786, 3787, 3788, 3789, 3790, 3791, 3792, 3793, 3794, 3795, 3796, 3797, 3798, 3799, 3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815, 3816, 3817, 3818, 3819}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide01 : TriggerState {
            internal StateGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99, key: "PortalOn", value: 1);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$02100002_BF__01_MAINCONTROL__5$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide02 : TriggerState {
            internal StateGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$02100002_BF__01_MAINCONTROL__6$", duration: 3000);
                context.SetInteractObject(interactIds: new []{10001239}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001239}, arg2: 0)) {
                    return new StateGuide03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide03 : TriggerState {
            internal StateGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "GuildRaid_RainbowSlimeFactory_MachineOn_01");
                context.SetEventUI(arg1: 1, script: "$02100002_BF__01_MAINCONTROL__7$", duration: 2000);
                context.SetInteractObject(interactIds: new []{10001239}, state: 0);
                context.SetUserValue(triggerId: 11, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerId: 12, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerId: 13, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerId: 14, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerId: 15, key: "ActivateTank", value: 1);
                context.SetUserValue(triggerId: 21, key: "ActivateHolder", value: 1);
                context.SetUserValue(triggerId: 22, key: "ActivateHolder", value: 1);
                context.SetUserValue(triggerId: 23, key: "ActivateHolder", value: 1);
                context.SetUserValue(triggerId: 24, key: "ActivateHolder", value: 1);
                context.SetUserValue(triggerId: 25, key: "ActivateHolder", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTimmerStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimmerStart : TriggerState {
            internal StateTimmerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99, key: "MissionStart", value: 1);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetTimer(timerId: "10000", seconds: 600, autoRemove: true, display: true, vOffset: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    return new StateEnableCheckOutput(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnableCheckOutput : TriggerState {
            internal StateEnableCheckOutput(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$02100002_BF__01_MAINCONTROL__8$", duration: 3000);
                context.SetInteractObject(interactIds: new []{10001240}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001240}, arg2: 0)) {
                    return new StateCheckSuccess(context);
                }

                if (context.TimeExpired(timerId: "10000")) {
                    return new StateMissionFail(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 11, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerId: 12, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerId: 13, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerId: 14, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerId: 15, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerId: 21, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerId: 22, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerId: 23, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerId: 24, key: "DungeonQuit", value: 1);
                context.SetUserValue(triggerId: 25, key: "DungeonQuit", value: 1);
                context.DestroyMonster(spawnIds: new []{900});
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10001234}, state: 0);
            }
        }

        private class StateCheckSuccess : TriggerState {
            internal StateCheckSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.RainbowMonster, condition: "IsMissionSuccess", value: "19-21")) {
                    return new StateHappyEndingStart(context);
                }

                if (!context.WidgetCondition(type: WidgetType.RainbowMonster, condition: "IsMissionSuccess", value: "19-21")) {
                    return new StateBadEndingStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBadEndingStart : TriggerState {
            internal StateBadEndingStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 909, enabled: true);
                context.PlaySystemSoundInBox(sound: "GuildRaid_RainbowSlimeFactory_Result_01");
                context.MoveUser(mapId: 02100002, portalId: 2, boxId: 9901);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBadEndingSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBadEndingSpawn : TriggerState {
            internal StateBadEndingSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 908, enabled: true);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.CreateMonster(spawnIds: new []{2000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBadEndingEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBadEndingEnd : TriggerState {
            internal StateBadEndingEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMissionFail(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(triggerId: 9902, type: "trigger", code: "MakeMutantKingSlime");
            }
        }

        private class StateHappyEndingStart : TriggerState {
            internal StateHappyEndingStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 909, enabled: true);
                context.PlaySystemSoundInBox(sound: "GuildRaid_RainbowSlimeFactory_Result_01");
                context.MoveUser(mapId: 02100002, portalId: 2, boxId: 9901);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateHappyEndingSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHappyEndingSpawn : TriggerState {
            internal StateHappyEndingSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 908, enabled: true);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.CreateMonster(spawnIds: new []{1000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateHappyEndingEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHappyEndingEnd : TriggerState {
            internal StateHappyEndingEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDungeonSuccess(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(triggerId: 9902, type: "trigger", code: "MakeRainbowKingSlime");
            }
        }

        private class StateDungeonSuccess : TriggerState {
            internal StateDungeonSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetAchievement(triggerId: 9902, type: "trigger", code: "Find02100002");
                context.SetEventUI(arg1: 7, script: "$02100002_BF__01_MAINCONTROL__10$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateExitPortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMissionFail : TriggerState {
            internal StateMissionFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "10000");
                context.SetEventUI(arg1: 5, script: "$02100002_BF__01_MAINCONTROL__9$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateDungeonFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFail : TriggerState {
            internal StateDungeonFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonFail();
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateExitPortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExitPortalOn : TriggerState {
            internal StateExitPortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetUserValue(triggerId: 99, key: "DungeonClear", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
