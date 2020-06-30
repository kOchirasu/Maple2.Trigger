using System;

namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_e_monster {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5501}, arg2: false);
                context.SetEffect(arg1: new int[] {5502}, arg2: false);
                context.SetEffect(arg1: new int[] {5503}, arg2: false);
                context.SetEffect(arg1: new int[] {5504}, arg2: false);
                context.SetEffect(arg1: new int[] {5505}, arg2: false);
                context.SetEffect(arg1: new int[] {5506}, arg2: false);
                context.SetEffect(arg1: new int[] {5507}, arg2: false);
                context.SetEffect(arg1: new int[] {5508}, arg2: false);
                context.SetEffect(arg1: new int[] {5509}, arg2: false);
                context.SetEffect(arg1: new int[] {5510}, arg2: false);
                context.SetEffect(arg1: new int[] {5511}, arg2: false);
                context.SetEffect(arg1: new int[] {5512}, arg2: false);
                context.SetEffect(arg1: new int[] {5513}, arg2: false);
                context.SetEffect(arg1: new int[] {5514}, arg2: false);
                context.SetEffect(arg1: new int[] {5515}, arg2: false);
                context.SetEffect(arg1: new int[] {5516}, arg2: false);
                context.SetEffect(arg1: new int[] {5517}, arg2: false);
                context.SetEffect(arg1: new int[] {5518}, arg2: false);
                context.SetEffect(arg1: new int[] {5519}, arg2: false);
                context.SetEffect(arg1: new int[] {5520}, arg2: false);
                context.SetEffect(arg1: new int[] {5521}, arg2: false);
                context.SetEffect(arg1: new int[] {5522}, arg2: false);
                context.SetEffect(arg1: new int[] {5523}, arg2: false);
                context.SetEffect(arg1: new int[] {5524}, arg2: false);
                context.SetEffect(arg1: new int[] {5525}, arg2: false);
                context.SetEffect(arg1: new int[] {5526}, arg2: false);
                context.SetEffect(arg1: new int[] {5527}, arg2: false);
                context.SetEffect(arg1: new int[] {5528}, arg2: false);
                context.SetEffect(arg1: new int[] {5529}, arg2: false);
                context.SetEffect(arg1: new int[] {5530}, arg2: false);
                context.SetEffect(arg1: new int[] {5531}, arg2: false);
                context.SetEffect(arg1: new int[] {5532}, arg2: false);
                context.SetEffect(arg1: new int[] {5533}, arg2: false);
                context.SetEffect(arg1: new int[] {5534}, arg2: false);
                context.SetEffect(arg1: new int[] {5535}, arg2: false);
                context.SetEffect(arg1: new int[] {5536}, arg2: false);
                context.SetEffect(arg1: new int[] {5537}, arg2: false);
                context.SetEffect(arg1: new int[] {5538}, arg2: false);
                context.SetEffect(arg1: new int[] {5539}, arg2: false);
                context.SetEffect(arg1: new int[] {5540}, arg2: false);
                context.SetEffect(arg1: new int[] {5541}, arg2: false);
                context.SetEffect(arg1: new int[] {5542}, arg2: false);
                context.SetEffect(arg1: new int[] {5543}, arg2: false);
                context.SetEffect(arg1: new int[] {5544}, arg2: false);
                context.SetEffect(arg1: new int[] {5545}, arg2: false);
                context.SetEffect(arg1: new int[] {5546}, arg2: false);
                context.SetEffect(arg1: new int[] {5547}, arg2: false);
                context.SetEffect(arg1: new int[] {5548}, arg2: false);
                context.SetEffect(arg1: new int[] {5549}, arg2: false);
                context.SetMesh(arg1: new int[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2009}, arg2: new int[] {91000053},
                    arg3: new byte[] {2})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {601}, arg2: true);
                context.CreateMonster(arg1: new int[] {602}, arg2: true);
                context.CreateMonster(arg1: new int[] {603}, arg2: true);
                context.CreateMonster(arg1: new int[] {604}, arg2: true);
                context.CreateMonster(arg1: new int[] {605}, arg2: true);
                context.CreateMonster(arg1: new int[] {606}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State크림슨발록_지시(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_지시 : TriggerState {
            internal State크림슨발록_지시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 603, msg: "$52010056_QD__EventSection_E_Monster__0$",
                    duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State크림슨스피어_대답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨스피어_대답 : TriggerState {
            internal State크림슨스피어_대답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 601, msg: "$52010056_QD__EventSection_E_Monster__1$",
                    duration: 1500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 602, msg: "$52010056_QD__EventSection_E_Monster__1$",
                    duration: 1500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 604, msg: "$52010056_QD__EventSection_E_Monster__1$",
                    duration: 1500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 605, msg: "$52010056_QD__EventSection_E_Monster__1$",
                    duration: 1500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 606, msg: "$52010056_QD__EventSection_E_Monster__1$",
                    duration: 1500, delayTick: 0);
                context.SetMesh(arg1: new int[] {9002, 9003, 9004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5501}, arg2: true);
                context.SetEffect(arg1: new int[] {5502}, arg2: true);
                context.SetEffect(arg1: new int[] {5503}, arg2: true);
                context.SetEffect(arg1: new int[] {5504}, arg2: true);
                context.SetEffect(arg1: new int[] {5505}, arg2: true);
                context.SetEffect(arg1: new int[] {5506}, arg2: true);
                context.SetEffect(arg1: new int[] {5507}, arg2: true);
                context.SetEffect(arg1: new int[] {5508}, arg2: true);
                context.SetEffect(arg1: new int[] {5509}, arg2: true);
                context.SetEffect(arg1: new int[] {5510}, arg2: true);
                context.SetEffect(arg1: new int[] {5511}, arg2: true);
                context.SetEffect(arg1: new int[] {5512}, arg2: true);
                context.SetEffect(arg1: new int[] {5513}, arg2: true);
                context.SetEffect(arg1: new int[] {5514}, arg2: true);
                context.SetEffect(arg1: new int[] {5515}, arg2: true);
                context.SetEffect(arg1: new int[] {5516}, arg2: true);
                context.SetEffect(arg1: new int[] {5517}, arg2: true);
                context.SetEffect(arg1: new int[] {5518}, arg2: true);
                context.SetEffect(arg1: new int[] {5519}, arg2: true);
                context.SetEffect(arg1: new int[] {5520}, arg2: true);
                context.SetEffect(arg1: new int[] {5521}, arg2: true);
                context.SetEffect(arg1: new int[] {5522}, arg2: true);
                context.SetEffect(arg1: new int[] {5523}, arg2: true);
                context.SetEffect(arg1: new int[] {5524}, arg2: true);
                context.SetEffect(arg1: new int[] {5525}, arg2: true);
                context.SetEffect(arg1: new int[] {5526}, arg2: true);
                context.SetEffect(arg1: new int[] {5527}, arg2: true);
                context.SetEffect(arg1: new int[] {5528}, arg2: true);
                context.SetEffect(arg1: new int[] {5529}, arg2: true);
                context.SetEffect(arg1: new int[] {5530}, arg2: true);
                context.SetEffect(arg1: new int[] {5531}, arg2: true);
                context.SetEffect(arg1: new int[] {5532}, arg2: true);
                context.SetEffect(arg1: new int[] {5533}, arg2: true);
                context.SetEffect(arg1: new int[] {5534}, arg2: true);
                context.SetEffect(arg1: new int[] {5535}, arg2: true);
                context.SetEffect(arg1: new int[] {5536}, arg2: true);
                context.SetEffect(arg1: new int[] {5537}, arg2: true);
                context.SetEffect(arg1: new int[] {5538}, arg2: true);
                context.SetEffect(arg1: new int[] {5539}, arg2: true);
                context.SetEffect(arg1: new int[] {5540}, arg2: true);
                context.SetEffect(arg1: new int[] {5541}, arg2: true);
                context.SetEffect(arg1: new int[] {5542}, arg2: true);
                context.SetEffect(arg1: new int[] {5543}, arg2: true);
                context.SetEffect(arg1: new int[] {5544}, arg2: true);
                context.SetEffect(arg1: new int[] {5545}, arg2: true);
                context.SetEffect(arg1: new int[] {5546}, arg2: true);
                context.SetEffect(arg1: new int[] {5547}, arg2: true);
                context.SetEffect(arg1: new int[] {5548}, arg2: true);
                context.SetEffect(arg1: new int[] {5549}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {601, 602, 603, 604, 605})) {
                    context.State = new StateMeshOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeshOff : TriggerState {
            internal StateMeshOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5501}, arg2: false);
                context.SetEffect(arg1: new int[] {5502}, arg2: false);
                context.SetEffect(arg1: new int[] {5503}, arg2: false);
                context.SetEffect(arg1: new int[] {5504}, arg2: false);
                context.SetEffect(arg1: new int[] {5505}, arg2: false);
                context.SetEffect(arg1: new int[] {5506}, arg2: false);
                context.SetEffect(arg1: new int[] {5507}, arg2: false);
                context.SetEffect(arg1: new int[] {5508}, arg2: false);
                context.SetEffect(arg1: new int[] {5509}, arg2: false);
                context.SetEffect(arg1: new int[] {5510}, arg2: false);
                context.SetEffect(arg1: new int[] {5511}, arg2: false);
                context.SetEffect(arg1: new int[] {5512}, arg2: false);
                context.SetEffect(arg1: new int[] {5513}, arg2: false);
                context.SetEffect(arg1: new int[] {5514}, arg2: false);
                context.SetEffect(arg1: new int[] {5515}, arg2: false);
                context.SetEffect(arg1: new int[] {5516}, arg2: false);
                context.SetEffect(arg1: new int[] {5517}, arg2: false);
                context.SetEffect(arg1: new int[] {5518}, arg2: false);
                context.SetEffect(arg1: new int[] {5519}, arg2: false);
                context.SetEffect(arg1: new int[] {5520}, arg2: false);
                context.SetEffect(arg1: new int[] {5521}, arg2: false);
                context.SetEffect(arg1: new int[] {5522}, arg2: false);
                context.SetEffect(arg1: new int[] {5523}, arg2: false);
                context.SetEffect(arg1: new int[] {5524}, arg2: false);
                context.SetEffect(arg1: new int[] {5525}, arg2: false);
                context.SetEffect(arg1: new int[] {5526}, arg2: false);
                context.SetEffect(arg1: new int[] {5527}, arg2: false);
                context.SetEffect(arg1: new int[] {5528}, arg2: false);
                context.SetEffect(arg1: new int[] {5529}, arg2: false);
                context.SetEffect(arg1: new int[] {5530}, arg2: false);
                context.SetEffect(arg1: new int[] {5531}, arg2: false);
                context.SetEffect(arg1: new int[] {5532}, arg2: false);
                context.SetEffect(arg1: new int[] {5533}, arg2: false);
                context.SetEffect(arg1: new int[] {5534}, arg2: false);
                context.SetEffect(arg1: new int[] {5535}, arg2: false);
                context.SetEffect(arg1: new int[] {5536}, arg2: false);
                context.SetEffect(arg1: new int[] {5537}, arg2: false);
                context.SetEffect(arg1: new int[] {5538}, arg2: false);
                context.SetEffect(arg1: new int[] {5539}, arg2: false);
                context.SetEffect(arg1: new int[] {5540}, arg2: false);
                context.SetEffect(arg1: new int[] {5541}, arg2: false);
                context.SetEffect(arg1: new int[] {5542}, arg2: false);
                context.SetEffect(arg1: new int[] {5543}, arg2: false);
                context.SetEffect(arg1: new int[] {5544}, arg2: false);
                context.SetEffect(arg1: new int[] {5545}, arg2: false);
                context.SetEffect(arg1: new int[] {5546}, arg2: false);
                context.SetEffect(arg1: new int[] {5547}, arg2: false);
                context.SetEffect(arg1: new int[] {5548}, arg2: false);
                context.SetEffect(arg1: new int[] {5549}, arg2: false);
                context.SetMesh(arg1: new int[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}