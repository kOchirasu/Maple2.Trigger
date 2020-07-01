using System;

namespace Maple2.Trigger._02010040_bf {
    public static class _battlezone03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {4301}, arg2: false);
                context.SetEffect(arg1: new int[] {4302}, arg2: false);
                context.SetEffect(arg1: new int[] {4303}, arg2: false);
                context.SetMesh(arg1: new int[] {1300}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1301}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1302}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 2300, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 2301, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 2302, arg2: true, arg3: "Closed");
                context.SetAgent(arg1: "3301", arg2: true);
                context.SetAgent(arg1: "3302", arg2: true);
                context.SetAgent(arg1: "3303", arg2: true);
                context.SetAgent(arg1: "3304", arg2: true);
                context.SetAgent(arg1: "3305", arg2: true);
                context.SetAgent(arg1: "3306", arg2: true);
                context.SetAgent(arg1: "3307", arg2: true);
                context.SetAgent(arg1: "3308", arg2: true);
                context.SetAgent(arg1: "3309", arg2: true);
                context.SetAgent(arg1: "3310", arg2: true);
                context.SetAgent(arg1: "3311", arg2: true);
                context.SetAgent(arg1: "3312", arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9300})) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {501, 502, 601, 602, 701, 702}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {501, 502, 601, 602, 701, 702})) {
                    context.State = new State문열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기 : TriggerState {
            internal State문열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1300}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1301}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1302}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {4301}, arg2: true);
                context.SetEffect(arg1: new int[] {4302}, arg2: true);
                context.SetEffect(arg1: new int[] {4303}, arg2: true);
                context.SetActor(arg1: 2300, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 2301, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 2302, arg2: true, arg3: "Opened");
                context.SetAgent(arg1: "3301", arg2: false);
                context.SetAgent(arg1: "3302", arg2: false);
                context.SetAgent(arg1: "3303", arg2: false);
                context.SetAgent(arg1: "3304", arg2: false);
                context.SetAgent(arg1: "3305", arg2: false);
                context.SetAgent(arg1: "3306", arg2: false);
                context.SetAgent(arg1: "3307", arg2: false);
                context.SetAgent(arg1: "3308", arg2: false);
                context.SetAgent(arg1: "3309", arg2: false);
                context.SetAgent(arg1: "3310", arg2: false);
                context.SetAgent(arg1: "3311", arg2: false);
                context.SetAgent(arg1: "3312", arg2: false);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}