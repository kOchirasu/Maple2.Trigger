namespace Maple2.Trigger._02000335_bf {
    public static class _train_open {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6920}, arg2: false);
                context.SetMesh(arg1: new[] {6091, 6092, 6093}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000786}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 709) == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 113, textId: 20003363);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000786}, arg2: 0)) {
                    return new State작동_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 113);
            }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6922}, arg2: true);
                context.SetMesh(arg1: new[] {6081, 6082, 6083}, arg2: false, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new[] {6091, 6092, 6093}, arg2: true, arg4: 300, arg5: 10f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State작동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_02 : TriggerState {
            internal State작동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6099, 6076}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new[] {6091, 6092, 6093}, arg2: false, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {6000}, arg2: false, arg4: 50, arg5: 1f);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벽Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽Remove : TriggerState {
            internal State벽Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6920}, arg2: true);
                context.SetSkill(arg1: new[] {5807, 5808, 5809}, arg2: true);
                context.SetMesh(arg1: new[] {7071, 7072, 7073, 7074}, arg2: false, arg4: 15, arg5: 8f);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {113}, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_01_조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_조건 : TriggerState {
            internal State관문_01_조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
                context.CreateMonster(arg1: new[] {115, 116, 137, 139}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {113})) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 105);
            }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362);
                context.SetMesh(arg1: new[] {6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218}, arg2: false, arg4: 0, arg5: 10f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State관문_01_개방_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 106);
            }
        }

        private class State관문_01_개방_02 : TriggerState {
            internal State관문_01_개방_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}