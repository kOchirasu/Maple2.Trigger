using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020020_qd {
    public static class _main_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200135}, questStates: new byte[]{2})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200135, 60200136, 60200137, 60200138, 60200139, 60200140}, questStates: new byte[]{3})) {
                    return new StateEndReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52020020, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonologue_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonologue_01 : TriggerState {
            internal StateMonologue_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "곧 알현식이 열린다고?", duration: 2500);
                context.SetPcEmotionLoop(sequenceName: "Object_React_H", duration: 16000f);
                context.SetSceneSkip(state: new StateEndReady(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateMonologue_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonologue_02 : TriggerState {
            internal StateMonologue_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "그럼 여기가 $map:02000001$$pp:라는,이라는$거야?", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateMonologue_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonologue_03 : TriggerState {
            internal StateMonologue_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "분명 알현식은 취소되었을텐데?", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWalk(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 4);
            }
        }

        private class StateWalk : TriggerState {
            internal StateWalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDoor(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoor : TriggerState {
            internal StateDoor(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventTalk_01 : TriggerState {
            internal StateEventTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003590, script: "앗! 일어나 계셨습니까?", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateEventTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventTalk_02 : TriggerState {
            internal StateEventTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "설마....", duration: 2500, align: Align.Right);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateEventTalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventTalk_03 : TriggerState {
            internal StateEventTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "설마.... 그럴리가 없어....", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEndReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndReady : TriggerState {
            internal StateEndReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetSound(triggerId: 7001, enabled: true);
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 100f);
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateExit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExit : TriggerState {
            internal StateExit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
