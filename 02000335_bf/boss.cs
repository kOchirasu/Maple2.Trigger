namespace Maple2.Trigger._02000335_bf {
    public static class _boss {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 991, isEnable: true);
                context.EnableSpawnPointPc(spawnId: 992, isEnable: false);
                context.SetMesh(triggerIds: new []{6311, 6312, 6313, 6314, 6315}, visible: true, arg4: 1, arg5: 1f);
                context.SetEffect(triggerIds: new []{6921}, visible: false);
                context.CreateMonster(spawnIds: new []{149}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{149})) {
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
                context.EnableSpawnPointPc(spawnId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 992, isEnable: true);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362);
                context.SetMesh(triggerIds: new []{7991, 7992, 7993}, visible: false, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
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

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000335_BF__BOSS__0$", duration: 3000);
                context.SetEffect(triggerIds: new []{6921}, visible: true);
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateBossSpawnCinematic_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic_01 : TriggerState {
            internal StateBossSpawnCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{141, 142, 143, 144, 145, 146, 147, 148});
                context.SetSkill(triggerIds: new []{5801, 5802}, arg2: true);
                context.SetEffect(triggerIds: new []{6911, 6912}, visible: true);
                context.CreateMonster(spawnIds: new []{199}, arg2: false);
                context.MoveNpc(spawnId: 199, patrolName: "MS2PatrolData_1003");
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateBossSpawnCinematic_02(context);
                }

                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StatePortalOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic_02 : TriggerState {
            internal StateBossSpawnCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{5803, 5804}, arg2: true);
                context.SetEffect(triggerIds: new []{6913, 6914}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateBossSpawnCinematic_03(context);
                }

                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StatePortalOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic_03 : TriggerState {
            internal StateBossSpawnCinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{5805, 5806}, arg2: true);
                context.SetEffect(triggerIds: new []{6915, 6916}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StatePortalOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOpen : TriggerState {
            internal StatePortalOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 112, textId: 40009);
                context.SetMesh(triggerIds: new []{6311, 6312, 6313, 6314, 6315}, visible: false, arg4: 0, arg5: 10f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 112);
            }
        }
    }
}
