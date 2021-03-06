namespace Maple2.Trigger._02000241_bf {
    public static class _trigger_04_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {307}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {707, 708}, arg2: true);
                context.SetMesh(arg1: new[] {309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324}, arg2: false);
                context.SetActor(arg1: 507, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 508, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 509, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 510, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 511, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 512, arg2: true, arg3: "Closed");
                context.DestroyMonster(arg1: new[] {607, 608, 609, 610, 611, 612});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {407})) {
                    return new State버튼눌림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼눌림 : TriggerState {
            internal State버튼눌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {307}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 511, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 512, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new[] {611, 612}, arg2: false);
                context.MoveNpc(arg1: 611, arg2: "MS2PatrolData_611");
                context.MoveNpc(arg1: 612, arg2: "MS2PatrolData_612");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}