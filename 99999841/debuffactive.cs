namespace Maple2.Trigger._99999841 {
    public static class _debuffactive {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 801) == true) {
                    return new StateReduceMoveSpeed(context);
                }

                if (context.GetDungeonVariable(id: 802) == true) {
                    return new StateReduceAttack(context);
                }

                if (context.GetDungeonVariable(id: 803) == true) {
                    return new StateReduceHealth(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReduceMoveSpeed : TriggerState {
            internal StateReduceMoveSpeed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 801, value: false);
                context.SetEventUI(arg1: 1, script: "이동속도 감소 디Buff에 걸립니다.", duration: 5000);
                context.AddBuff(boxIds: new []{9001}, skillId: 70002581, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                // return new StateEnd(context);
                    return null;
            }

            public override void OnExit() { }
        }

        private class StateReduceAttack : TriggerState {
            internal StateReduceAttack(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 802, value: false);
                context.SetEventUI(arg1: 1, script: "공격력 감소 디Buff에 걸립니다.", duration: 5000);
                context.AddBuff(boxIds: new []{9001}, skillId: 70002591, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                // return new StateEnd(context);
                    return null;
            }

            public override void OnExit() { }
        }

        private class StateReduceHealth : TriggerState {
            internal StateReduceHealth(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 803, value: false);
                context.SetEventUI(arg1: 1, script: "체력 감소 디Buff에 걸립니다.", duration: 5000);
                context.AddBuff(boxIds: new []{9001}, skillId: 70002601, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                // return new StateEnd(context);
                    return null;
            }

            public override void OnExit() { }
        }
    }
}
