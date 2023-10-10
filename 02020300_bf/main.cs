using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020300_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "Spawn", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "RandomBomb", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Laser", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "elevator", value: 0);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10002185}, state: 0);
                context.EnableSpawnPointPc(spawnId: 100, enabled: true);
                context.EnableSpawnPointPc(spawnId: 101, enabled: false);
                context.EnableSpawnPointPc(spawnId: 102, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    context.SetEventUI(arg1: 1, script: "$02020300_BF__MAIN__0$", duration: 5000);
                    context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
                    return new State추가Script_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_01 : TriggerState {
            internal State추가Script_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetUserValue(triggerId: 99990004, key: "Laser", value: 1);
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$02020300_BF__MAIN__1$", duration: 5000);
                    return new State추가Script_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_02 : TriggerState {
            internal State추가Script_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_normal", script: "$02020300_BF__MAIN__2$", duration: 5000);
                    return new State추가Script_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_03 : TriggerState {
            internal State추가Script_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_normal", script: "$02020300_BF__MAIN__3$", duration: 5000);
                    return new State엘리베이터_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_체크 : TriggerState {
            internal State엘리베이터_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_normal", script: "$02020300_BF__MAIN__4$", duration: 5000);
                    return new State엘리베이터_스위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_스위치 : TriggerState {
            internal State엘리베이터_스위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002185}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002185}, arg2: 0)) {
                    return new State엘리베이터Enabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터Enabled : TriggerState {
            internal State엘리베이터Enabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{5001}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{903})) {
                    return new State아르케온_탑승_Guide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온_탑승_Guide : TriggerState {
            internal State아르케온_탑승_Guide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020300_BF__MAIN__5$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{711})) {
                    context.SetUserValue(triggerId: 99990005, key: "elevator", value: 1);
                    context.EnableSpawnPointPc(spawnId: 100, enabled: false);
                    context.EnableSpawnPointPc(spawnId: 101, enabled: true);
                    context.EnableSpawnPointPc(spawnId: 102, enabled: false);
                    return new State레이저_Pattern_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_Pattern_시작 : TriggerState {
            internal State레이저_Pattern_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{904})) {
                    return new State갈림길_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State갈림길_전투 : TriggerState {
            internal State갈림길_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204}, arg2: false);
                context.SetActor(triggerId: 9001, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_end");
                context.SetMesh(triggerIds: new []{1001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{905})) {
                    return new State짜투리_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State짜투리_전투 : TriggerState {
            internal State짜투리_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304}, arg2: false);
                context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004, 30000, 30010, 30020, 30030}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{911})) {
                    return new State웨이브_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브_시작 : TriggerState {
            internal State웨이브_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_unfair", script: "$02020300_BF__MAIN__6$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004, 30000, 30010, 30020, 30030}, visible: false);
                    return new State추가Script_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_04 : TriggerState {
            internal State추가Script_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$02020300_BF__MAIN__7$", duration: 5000);
                context.SetUserValue(triggerId: 99990002, key: "Spawn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnRoomEnd") == 1) {
                    context.SetActor(triggerId: 9001, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_start");
                    return new State길열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길열림 : TriggerState {
            internal State길열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1001}, visible: false);
                context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004, 30000, 30010, 30020, 30030}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{921})) {
                    return new State지뢰방_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지뢰방_시작 : TriggerState {
            internal State지뢰방_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 100, enabled: false);
                context.EnableSpawnPointPc(spawnId: 101, enabled: false);
                context.EnableSpawnPointPc(spawnId: 102, enabled: true);
                context.SetActor(triggerId: 9002, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_end");
                context.SetActor(triggerId: 9003, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_end");
                context.SetActor(triggerId: 9004, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_end");
                context.SetMesh(triggerIds: new []{5001}, visible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003}, visible: true);
                context.SetUserValue(triggerId: 99990003, key: "RandomBomb", value: 1);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$02020300_BF__MAIN__8$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_05 : TriggerState {
            internal State추가Script_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_normal", script: "$02020300_BF__MAIN__9$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_06 : TriggerState {
            internal State추가Script_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_normal", script: "$02020300_BF__MAIN__10$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RandomBombEnd") == 1) {
                    context.SetUserValue(triggerId: 99990004, key: "Laser", value: 0);
                    return new StateBoss(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss : TriggerState {
            internal StateBoss(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_normal", script: "$02020300_BF__MAIN__11$", duration: 5000);
                context.SetActor(triggerId: 9002, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_start");
                context.SetMesh(triggerIds: new []{3001}, visible: false);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990005, key: "elevator", value: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
