using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020010_qd {
    public static class _main_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2006}, arg2: new[] {60200055}, arg3: new byte[] {1})) {
                    return new StateObject_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateObject_Check : TriggerState {
            internal StateObject_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001276}, arg2: 0)) {
                    return new StateReady(context);
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
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMove_6001(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMove_6001 : TriggerState {
            internal StateMove_6001(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020010, arg2: 6002);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetPcEmotionSequence(arg1: "Object_React_H");
                context.AddCinematicTalk(npcId: 0, script: "왜 아무일도 일어나지 않는거지?", duration: 2800);
                context.SetSceneSkip(state: new StateNext(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Object_React_G");
                context.AddCinematicTalk(npcId: 0, script: "두들겨 볼까?", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003610, script: "으으으.... 시끄럽구나!", duration: 2800);
                context.AddBalloonTalk(spawnPointId: 0, msg: "!!!", duration: 2000, delayTick: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {501}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003610, script: "네 놈이냐! 내 잠을 깨운 녀석이!", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003610, script: "감히 내 시간을 방해하다니 가만두지 않겠다!", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNext(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNext : TriggerState {
            internal StateNext(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {501});
                context.CreateMonster(arg1: new[] {601}, arg2: true);
            }

            public override TriggerState Execute() {
                return new StateBattle(context);
            }

            public override void OnExit() { }
        }

        private class StateBattle : TriggerState {
            internal StateBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {601})) {
                    return new StateMission_Clear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMission_Clear : TriggerState {
            internal StateMission_Clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg2: "trigger", arg3: "ClockDevil");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2006}, arg2: new[] {60200050}, arg3: new byte[] {1})) {
                    return new StateMission_Clear(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2006}, arg2: new[] {60200055}, arg3: new byte[] {2})) {
                    return new StateEvent_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_07 : TriggerState {
            internal StateEvent_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003603, illustId: "0", script: "인간! 파편이 돌아왔다! 어서 이리 와라!", duration: 2800, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_End : TriggerState {
            internal StateEvent_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}