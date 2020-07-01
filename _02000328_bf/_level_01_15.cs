namespace Maple2.Trigger._02000328_bf {
    public static class _level_01_15 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5115}, isVisible: false);
                context.SetMesh(
                    arg1: new[] {
                        32501, 32502, 32503, 32504, 32505, 32506, 32507, 32508, 32509, 32510, 32511, 32512, 32513,
                        32514, 32515, 32516, 32517, 32518, 32519, 32520, 32521, 32522, 32523, 32524, 32525, 32526,
                        32527, 32528, 32529, 32530, 32531, 32532, 32533, 32534, 32535, 32536, 32537, 32538
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111, 8112, 8113, 8114, 8115
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        8200, 8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212, 8213, 8214, 8215
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {10015})) {
                    context.SetCube(ids: new[] {5115}, isVisible: true);
                    context.SetMesh(
                        arg1: new[] {
                            32501, 32502, 32503, 32504, 32505, 32506, 32507, 32508, 32509, 32510, 32511, 32512, 32513,
                            32514, 32515, 32516, 32517, 32518, 32519, 32520, 32521, 32522, 32523, 32524, 32525, 32526,
                            32527, 32528, 32529, 32530, 32531, 32532, 32533, 32534, 32535, 32536, 32537, 32538
                        }, arg2: true, arg3: 0, arg4: 100, arg5: 1f);
                    context.SetMesh(
                        arg1: new[] {
                            8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111, 8112, 8113, 8114,
                            8115
                        }, arg2: true, arg3: 0, arg4: 100, arg5: 1f);
                    context.SetMesh(
                        arg1: new[] {
                            8200, 8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212, 8213, 8214,
                            8215
                        }, arg2: false, arg3: 500, arg4: 100, arg5: 1f);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}