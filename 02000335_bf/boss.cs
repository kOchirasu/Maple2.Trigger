namespace Maple2.Trigger._02000335_bf {
    public static class _boss {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 991, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 992, isEnable: false);
                context.SetMesh(arg1: new[] {6311, 6312, 6313, 6314, 6315}, arg2: true, arg4: 1, arg5: 1f);
                context.SetEffect(arg1: new[] {6921}, arg2: false);
                context.CreateMonster(arg1: new[] {149}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 710) == 1) {
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
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {149})) {
                    return new State화물문_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 105);
            }
        }

        private class State화물문_개방 : TriggerState {
            internal State화물문_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 992, isEnable: true);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362);
                context.SetMesh(arg1: new[] {7991, 7992, 7993}, arg2: false, arg4: 0, arg5: 0f);
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State화물문_개방_종료(context);
                }

                if (context.GetUserCount(boxId: 711) == 1) {
                    return new StateBossSpawnCinematic_00(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 106);
            }
        }

        private class State화물문_개방_종료 : TriggerState {
            internal State화물문_개방_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 711) == 1) {
                    return new StateBossSpawnCinematic_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic_00 : TriggerState {
            internal StateBossSpawnCinematic_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000335_BF__BOSS__0$", arg3: 3000);
                context.SetEffect(arg1: new[] {6921}, arg2: true);
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateBossSpawnCinematic_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic_01 : TriggerState {
            internal StateBossSpawnCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {141, 142, 143, 144, 145, 146, 147, 148});
                context.SetSkill(arg1: new[] {5801, 5802}, arg2: true);
                context.SetEffect(arg1: new[] {6911, 6912}, arg2: true);
                context.CreateMonster(arg1: new[] {199}, arg2: false);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_1003");
                context.SetTimer(id: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBossSpawnCinematic_02(context);
                }

                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic_02 : TriggerState {
            internal StateBossSpawnCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {5803, 5804}, arg2: true);
                context.SetEffect(arg1: new[] {6913, 6914}, arg2: true);
                context.SetTimer(id: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBossSpawnCinematic_03(context);
                }

                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic_03 : TriggerState {
            internal StateBossSpawnCinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {5805, 5806}, arg2: true);
                context.SetEffect(arg1: new[] {6915, 6916}, arg2: true);
                context.SetTimer(id: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOpen : TriggerState {
            internal StatePortalOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 112, textId: 40009);
                context.SetMesh(arg1: new[] {6311, 6312, 6313, 6314, 6315}, arg2: false, arg4: 0, arg5: 10f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 112);
            }
        }
    }
}