namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_e_monster {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5513, 5514, 5515, 5516, 5517, 5518, 5519, 5520, 5521, 5522, 5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5539, 5540, 5541, 5542, 5543, 5544, 5545, 5546, 5547, 5548, 5549}, arg2: false);
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2009}, arg2: new[] {91000053}, arg3: new byte[] {2})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {601, 602, 603, 604, 605, 606}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State크림슨발록_지시(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨발록_지시 : TriggerState {
            internal State크림슨발록_지시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 603, msg: "$52010056_QD__EventSection_E_Monster__0$", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State크림슨스피어_대답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크림슨스피어_대답 : TriggerState {
            internal State크림슨스피어_대답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 601, msg: "$52010056_QD__EventSection_E_Monster__1$", duration: 1500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 602, msg: "$52010056_QD__EventSection_E_Monster__1$", duration: 1500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 604, msg: "$52010056_QD__EventSection_E_Monster__1$", duration: 1500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 605, msg: "$52010056_QD__EventSection_E_Monster__1$", duration: 1500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 606, msg: "$52010056_QD__EventSection_E_Monster__1$", duration: 1500, delayTick: 0);
                context.SetMesh(arg1: new[] {9002, 9003, 9004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5513, 5514, 5515, 5516, 5517, 5518, 5519, 5520, 5521, 5522, 5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5539, 5540, 5541, 5542, 5543, 5544, 5545, 5546, 5547, 5548, 5549}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {601, 602, 603, 604, 605})) {
                    return new StateMeshOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeshOff : TriggerState {
            internal StateMeshOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5513, 5514, 5515, 5516, 5517, 5518, 5519, 5520, 5521, 5522, 5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5539, 5540, 5541, 5542, 5543, 5544, 5545, 5546, 5547, 5548, 5549}, arg2: false);
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}