namespace Maple2.Trigger._02000301_bf {
    public static class _trap_03 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetInteractObject(arg1: new[] {10000512}, arg2: 1);
                context.SetEffect(arg1: new[] {605, 601, 604, 610}, arg2: false);
                context.SetMesh(arg1: new[] {3031, 3032, 3033, 3034, 3035, 3036}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4301, 4302, 4303, 4304, 4305, 4306}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10301})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10302})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10303})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10304})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10305})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000512}, arg2: 0)) {
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetInteractObject(arg1: new[] {10000512}, arg2: 0);
                context.CreateMonster(arg1: new[] {2004}, arg2: false);
                context.SetEffect(arg1: new[] {605, 601, 604, 610}, arg2: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetMesh(arg1: new[] {3031, 3032, 3033, 3034, 3035, 3036}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4301, 4302, 4303, 4304, 4305, 4306}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2004})) {
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetEffect(arg1: new[] {610}, arg2: false);
                    context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2004});
                context.SetMesh(arg1: new[] {3031, 3032, 3033, 3034, 3035, 3036}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new[] {4301, 4302, 4303, 4304, 4305, 4306}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}