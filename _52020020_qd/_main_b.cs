using System;

namespace Maple2.Trigger._52020020_qd {
    public static class _main_b {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200135},
                    arg3: new byte[] {2})) {
                    context.State = new Stateready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001},
                    arg2: new int[] {60200135, 60200136, 60200137, 60200138, 60200139, 60200140},
                    arg3: new byte[] {3})) {
                    context.State = new StateEndReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52020020, arg2: 6002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMonologue_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMonologue_01 : TriggerState {
            internal StateMonologue_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 0, msg: "곧 알현식이 열린다고?", duration: 2500);
                context.SetPcEmotionLoop(arg1: "Object_React_H", arg2: 16000f);
                context.SetSceneSkip(arg1: "EndReady", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateMonologue_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMonologue_02 : TriggerState {
            internal StateMonologue_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "그럼 여기가 $map:02000001$$pp:라는,이라는$거야?", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateMonologue_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMonologue_03 : TriggerState {
            internal StateMonologue_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "분명 알현식은 취소되었을텐데?", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateWalk(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 4);
            }
        }

        private class StateWalk : TriggerState {
            internal StateWalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateDoor(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDoor : TriggerState {
            internal StateDoor(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventTalk_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventTalk_01 : TriggerState {
            internal StateEventTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003590, msg: "앗! 일어나 계셨습니까?", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateEventTalk_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventTalk_02 : TriggerState {
            internal StateEventTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "설마....", duration: 2500, align: "Right");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateEventTalk_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventTalk_03 : TriggerState {
            internal StateEventTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "설마.... 그럴리가 없어....", duration: 3000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEndReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEndReady : TriggerState {
            internal StateEndReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetSound(arg1: 7001, arg2: true);
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 100f);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateexit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateexit : TriggerState {
            internal Stateexit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}