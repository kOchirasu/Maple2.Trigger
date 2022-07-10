using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000313_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006}, visible: false);
                context.SetLadder(triggerId: 4001, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4002, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4003, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4004, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4005, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4006, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4007, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4008, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4101, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4102, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4103, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 4104, visible: false, animationEffect: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1099, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{15})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1001, 2001}, arg2: false);
                context.CameraSelect(triggerId: 30000, enable: true);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new State1차전투시작(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State1차전투시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 30000, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State1차전투시작 : TriggerState {
            internal State1차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20031300, textId: 20031300, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State1차전투시작2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투시작2 : TriggerState {
            internal State1차전투시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20031301, textId: 20031301, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new State1차NPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차NPC이동 : TriggerState {
            internal State1차NPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 10101, spawnIds: new []{1001})) {
                    context.DestroyMonster(spawnIds: new []{1001});
                    context.CreateMonster(spawnIds: new []{1002}, arg2: false);
                    return new State2차전투Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투Wait : TriggerState {
            internal State2차전투Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20031302, textId: 20031302, duration: 4000);
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10102})) {
                    return new State2차전투Delay(context);
                }

                if (context.MonsterInCombat(spawnIds: new []{2002})) {
                    return new State2차전투Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투Delay : TriggerState {
            internal State2차전투Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State2차전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투시작 : TriggerState {
            internal State2차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1002});
                context.CreateMonster(spawnIds: new []{1003}, arg2: false);
                context.SetLadder(triggerId: 4001, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4002, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4003, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4004, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4005, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4006, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4007, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4008, visible: true, animationEffect: true);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2002})) {
                    return new State2차NPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차NPC이동 : TriggerState {
            internal State2차NPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003B");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 10104, spawnIds: new []{1003})) {
                    context.DestroyMonster(spawnIds: new []{1003});
                    context.CreateMonster(spawnIds: new []{1004}, arg2: false);
                    return new State3차전투Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투Wait : TriggerState {
            internal State3차전투Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2003}, arg2: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20031302, textId: 20031302, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10103})) {
                    return new State3차전투Delay(context);
                }

                if (context.MonsterInCombat(spawnIds: new []{2003})) {
                    return new State3차전투Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투Delay : TriggerState {
            internal State3차전투Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State3차전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투시작 : TriggerState {
            internal State3차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1004});
                context.CreateMonster(spawnIds: new []{1005}, arg2: false);
                context.SetLadder(triggerId: 4101, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4102, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4103, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 4104, visible: true, animationEffect: true);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2003})) {
                    return new StateBossSpawnCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic : TriggerState {
            internal StateBossSpawnCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 30001, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBossSpawnCinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic2 : TriggerState {
            internal StateBossSpawnCinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1099, 1005});
                context.CreateMonster(spawnIds: new []{2099}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateBossSpawnCinematic3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic3 : TriggerState {
            internal StateBossSpawnCinematic3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 1101, sequenceName: "Dead_A", duration: 9000f);
                context.SetNpcEmotionLoop(spawnId: 1102, sequenceName: "Dead_A", duration: 9000f);
                context.SetNpcEmotionLoop(spawnId: 1103, sequenceName: "Dead_A", duration: 9000f);
                context.SetNpcEmotionLoop(spawnId: 1104, sequenceName: "Dead_A", duration: 9000f);
                context.SetNpcEmotionLoop(spawnId: 1105, sequenceName: "Dead_A", duration: 9000f);
                context.SetNpcEmotionLoop(spawnId: 1106, sequenceName: "Dead_A", duration: 9000f);
                context.SetNpcEmotionLoop(spawnId: 1107, sequenceName: "Dead_A", duration: 9000f);
                context.SetNpcEmotionLoop(spawnId: 1108, sequenceName: "Dead_A", duration: 9000f);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkip(state: new StateBossCombatStart(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossCombatStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 30001, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108});
                context.SetNpcEmotionLoop(spawnId: 1005, sequenceName: "Dead_Idle_A", duration: 9999999999999999f);
                context.SetEffect(triggerIds: new []{5002}, visible: false);
            }
        }

        private class StateBossCombatStart : TriggerState {
            internal StateBossCombatStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20031303, textId: 20031303, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBossCombatStart2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatStart2 : TriggerState {
            internal StateBossCombatStart2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20031304, textId: 20031304, duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2099})) {
                    return new StateQuest체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크 : TriggerState {
            internal StateQuest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateEnd(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuest코드확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 12, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest코드확인 : TriggerState {
            internal StateQuest코드확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9997}, questIds: new []{10003105}, questStates: new byte[]{2})) {
                    return new StateQuestCinematic_시작(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9998}, questIds: new []{10003105}, questStates: new byte[]{2})) {
                    return new StateQuestCinematic_시작(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9999}, questIds: new []{10003105}, questStates: new byte[]{2})) {
                    return new StateQuestCinematic_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_시작 : TriggerState {
            internal StateQuestCinematic_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 9, script: "$02000313_BF__BOSSSPAWN__43$", arg3: false);
                context.CreateMonster(spawnIds: new []{205, 202, 203, 204}, arg2: true);
                context.MoveUser(mapId: 02000313, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateQuestCinematic_상황보여주기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_01 : TriggerState {
            internal StateQuestCinematic_상황보여주기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuestEndCinematic_이동(context), arg2: "exit");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 30000, enable: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, script: "$02000313_BF__BOSSSPAWN__44$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003392, script: "$02000313_BF__BOSSSPAWN__45$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 205, sequenceName: "Stun_A", duration: 160000000f);
                context.SetNpcEmotionLoop(spawnId: 203, sequenceName: "Attack_Idle_A", duration: 160000000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuestCinematic_상황보여주기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_02 : TriggerState {
            internal StateQuestCinematic_상황보여주기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4012}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Bore_A");
                context.FaceEmotion(spawnId: 203, emotionName: "Trigger_Sad");
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__46$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__47$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuestCinematic_상황보여주기_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_03 : TriggerState {
            internal StateQuestCinematic_상황보여주기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 203, sequenceName: "Attack_Idle_A", duration: 999999999f);
                context.SetNpcEmotionSequence(spawnId: 204, sequenceName: "Talk_A,Bore_B");
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.AddCinematicTalk(npcId: 11003454, script: "$02000313_BF__BOSSSPAWN__48$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestCinematic_상황보여주기_04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_04_1 : TriggerState {
            internal StateQuestCinematic_상황보여주기_04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 203, emotionName: "Trigger_Danger");
                context.AddCinematicTalk(npcId: 11003387, script: "$02000313_BF__BOSSSPAWN__49$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003387, script: "$02000313_BF__BOSSSPAWN__50$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003454, script: "$02000313_BF__BOSSSPAWN__51$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateQuestCinematic_상황보여주기_04_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_04_2 : TriggerState {
            internal StateQuestCinematic_상황보여주기_04_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011}, returnView: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Talk_A"});
                context.AddCinematicTalk(npcId: 0, script: "$02000313_BF__BOSSSPAWN__52$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__53$", duration: 3000);
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
                context.AddBalloonTalk(spawnId: 0, msg: "$02000313_BF__BOSSSPAWN__54$", duration: 2000, delayTick: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuestCinematic_상황보여주기_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_04 : TriggerState {
            internal StateQuestCinematic_상황보여주기_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 201, emotionName: "Talk");
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Idle_A", duration: 999999999f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuestCinematic_상황보여주기_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_05 : TriggerState {
            internal StateQuestCinematic_상황보여주기_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_9991");
                context.AddCinematicTalk(npcId: 11003387, script: "$02000313_BF__BOSSSPAWN__55$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestCinematic_상황보여주기_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_06 : TriggerState {
            internal StateQuestCinematic_상황보여주기_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Idle_A", duration: 999999999f);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__56$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__57$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuestCinematic_상황보여주기_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_07 : TriggerState {
            internal StateQuestCinematic_상황보여주기_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.AddCinematicTalk(npcId: 11003387, script: "$02000313_BF__BOSSSPAWN__58$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestCinematic_상황보여주기_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_08 : TriggerState {
            internal StateQuestCinematic_상황보여주기_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4018}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Idle_A", duration: 999999999f);
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Bore_A");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_9994");
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__15$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestCinematic_상황보여주기_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_09 : TriggerState {
            internal StateQuestCinematic_상황보여주기_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Attack_Idle_A", duration: 999999999f);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__59$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__60$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuestCinematic_상황보여주기_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_10 : TriggerState {
            internal StateQuestCinematic_상황보여주기_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_9995");
                context.AddCinematicTalk(npcId: 11003387, script: "$02000313_BF__BOSSSPAWN__61$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$02000313_BF__BOSSSPAWN__62$", duration: 3000);
                context.SetNpcEmotionSequence(spawnId: 204, sequenceName: "Talk_A");
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Attack_01_C");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuestCinematic_상황보여주기_10_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_10_1 : TriggerState {
            internal StateQuestCinematic_상황보여주기_10_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__63$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__64$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Attack_Idle_A", duration: 999999999f);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__65$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__66$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$02000313_BF__BOSSSPAWN__67$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateQuestCinematic_상황보여주기_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_11 : TriggerState {
            internal StateQuestCinematic_상황보여주기_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "ChatUp_A");
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_Proud");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_9996");
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__68$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__69$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateQuestCinematic_상황보여주기_11_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_11_1 : TriggerState {
            internal StateQuestCinematic_상황보여주기_11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.AddCinematicTalk(npcId: 11003387, script: "$02000313_BF__BOSSSPAWN__70$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 203, sequenceName: "Sit_Down_A", duration: 10000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestCinematic_상황보여주기_11_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_11_2 : TriggerState {
            internal StateQuestCinematic_상황보여주기_11_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4018}, returnView: false);
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__71$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestCinematic_상황보여주기_11_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_11_3 : TriggerState {
            internal StateQuestCinematic_상황보여주기_11_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Bore_A");
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_Sad");
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__72$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__73$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__74$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateQuestCinematic_상황보여주기_11_4_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_11_4_1 : TriggerState {
            internal StateQuestCinematic_상황보여주기_11_4_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 201, emotionName: "Trigger_Proud");
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__75$", duration: 6060);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6060)) {
                    return new StateQuestCinematic_상황보여주기_11_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_11_4 : TriggerState {
            internal StateQuestCinematic_상황보여주기_11_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4019}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Attack_01_A");
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__76$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__77$", duration: 4000);
                context.SetSkip(state: new StateQuestCinematic_마지막전투_04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateQuestCinematic_상황보여주기_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_12 : TriggerState {
            internal StateQuestCinematic_상황보여주기_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014}, returnView: false);
                context.AddCinematicTalk(npcId: 11003387, script: "$02000313_BF__BOSSSPAWN__78$", duration: 3000);
                context.FaceEmotion(spawnId: 203, emotionName: "Trigger_Embarrassed");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestCinematic_상황보여주기_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_상황보여주기_13 : TriggerState {
            internal StateQuestCinematic_상황보여주기_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4018}, returnView: false);
                context.VisibleMyPc(visible: false);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_A");
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Attack_01_C");
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__79$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__80$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__81$", duration: 3000);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.DestroyMonster(spawnIds: new []{203, 204});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateQuestCinematic_마지막전투_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_마지막전투_01 : TriggerState {
            internal StateQuestCinematic_마지막전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4020}, returnView: false);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionSequence(spawnId: 205, sequenceName: "Attack_04_G");
                context.AddCinematicTalk(npcId: 11003392, script: "$02000313_BF__BOSSSPAWN__82$", duration: 1500);
                context.SetEffect(triggerIds: new []{5004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateQuestCinematic_마지막전투_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_마지막전투_02 : TriggerState {
            internal StateQuestCinematic_마지막전투_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4017}, returnView: false);
                context.VisibleMyPc(visible: false);
                context.AddCinematicTalk(npcId: 11003393, script: "$02000313_BF__BOSSSPAWN__83$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003407, script: "$02000313_BF__BOSSSPAWN__84$", duration: 3000);
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionSequence(spawnId: 205, sequenceName: "Attack_02_H");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new StateQuestCinematic_마지막전투_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_마지막전투_03 : TriggerState {
            internal StateQuestCinematic_마지막전투_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_9993");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_9992");
                context.SetNpcEmotionSequence(spawnId: 205, sequenceName: "Attack_04_G");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestCinematic_마지막전투_03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_마지막전투_03_1 : TriggerState {
            internal StateQuestCinematic_마지막전투_03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4017}, returnView: false);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionSequence(spawnId: 205, sequenceName: "Dead_A");
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Attack_01_B");
                context.SetEffect(triggerIds: new []{5003, 5005}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateQuestCinematic_마지막전투_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_마지막전투_04 : TriggerState {
            internal StateQuestCinematic_마지막전투_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{201, 202, 205});
                context.CreateMonster(spawnIds: new []{206, 207}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5003, 5004}, visible: false);
                context.SetNpcEmotionLoop(spawnId: 206, sequenceName: "Dead_A", duration: 1000000f);
                context.SetNpcEmotionLoop(spawnId: 207, sequenceName: "Dead_B", duration: 1000000f);
                context.FaceEmotion(spawnId: 206, emotionName: "Trigger_Dead");
                context.FaceEmotion(spawnId: 207, emotionName: "Trigger_Dead");
                context.SetEffect(triggerIds: new []{5006}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuestCinematic_마지막전투_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_마지막전투_05 : TriggerState {
            internal StateQuestCinematic_마지막전투_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG\weather\Eff_monochrome_03.xml");
                context.CameraSelectPath(pathIds: new []{4021, 4022}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuestCinematic_마지막전투_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_마지막전투_06 : TriggerState {
            internal StateQuestCinematic_마지막전투_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG\weather\Eff_monochrome_03.xml");
                context.SetCinematicUI(type: 9, script: "$02000313_BF__BOSSSPAWN__85$", arg3: false);
                context.SetEffect(triggerIds: new []{5005, 5006}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateQuestCinematic_마지막전투_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_마지막전투_07 : TriggerState {
            internal StateQuestCinematic_마지막전투_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$02000313_BF__BOSSSPAWN__86$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuestCinematic_마지막전투_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCinematic_마지막전투_08 : TriggerState {
            internal StateQuestCinematic_마지막전투_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestEndCinematic_이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestEndCinematic_이동 : TriggerState {
            internal StateQuestEndCinematic_이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 52010032, portalId: 3);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
