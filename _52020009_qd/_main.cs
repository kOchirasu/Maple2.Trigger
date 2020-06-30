using System;

namespace Maple2.Trigger._52020009_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8001}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001266}, arg2: 0);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
                context.SetEffect(arg1: new int[] {5102}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200020},
                    arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200020},
                    arg3: new byte[] {2})) {
                    context.State = new StateMeshOff(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200020},
                    arg3: new byte[] {3})) {
                    context.State = new StateMeshOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.CreateMonster(arg1: new int[] {203}, arg2: true);
                context.CreateMonster(arg1: new int[] {204}, arg2: true);
                context.CreateMonster(arg1: new int[] {205}, arg2: true);
                context.CreateMonster(arg1: new int[] {206}, arg2: true);
                context.CreateMonster(arg1: new int[] {207}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
                context.SetEffect(arg1: new int[] {5006}, arg2: true);
                context.SetMesh(arg1: new int[] {8001}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 0, msg: "!", duration: 3000, delayTick: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201, 202, 203, 204, 205, 206, 207})) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001266}, arg2: 1);
                context.SetMesh(arg1: new int[] {8001}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000449}, arg2: 0)) {
                    context.State = new StateMeshOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeshOff : TriggerState {
            internal StateMeshOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200020},
                    arg3: new byte[] {1})) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}