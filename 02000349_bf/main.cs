using Maple2.Trigger._dungeon_common;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000349_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001});
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 202, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 204, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 206, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "Idle_A");
                context.SetInteractObject(interactIds: new []{10000806, 10000806, 10000807, 10000808, 10000809, 10000810, 10000811, 10000812, 13000014}, state: 2);
                context.SetMesh(triggerIds: new []{39101, 39102, 39103, 39104, 39105, 39106, 3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815, 3816}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{600, 601, 602, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6201, 6202, 6203, 6204, 6205}, visible: false);
                context.SetSkill(triggerIds: new []{701, 702, 703, 704}, arg2: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetAgent(triggerIds: new []{901, 902, 903, 904}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "KatvanIntroMovie.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State진행01벽Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행01벽Remove : TriggerState {
            internal State진행01벽Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: false, initialSequence: "Idle_A");
                context.SetInteractObject(interactIds: new []{10000806}, state: 1);
                context.ShowGuideSummary(entityId: 20003492, textId: 20003492);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000806}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003492);
                    context.SetMesh(triggerIds: new []{39101}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State진행01Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행01Monster : TriggerState {
            internal State진행01Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1101})) {
                    return new State진행01오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행01오브젝트 : TriggerState {
            internal State진행01오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003496, textId: 20003496);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetActor(triggerId: 202, visible: false, initialSequence: "Idle_A");
                context.SetInteractObject(interactIds: new []{10000807}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000807}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003496);
                    return new State진행02Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행02Monster : TriggerState {
            internal State진행02Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{39102}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1004, 1005, 1006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1102})) {
                    return new State진행02오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행02오브젝트 : TriggerState {
            internal State진행02오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003497, textId: 20003497);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetActor(triggerId: 203, visible: false, initialSequence: "Idle_A");
                context.SetInteractObject(interactIds: new []{10000808}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000808}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003497);
                    return new State진행03Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행03Monster : TriggerState {
            internal State진행03Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{39103}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1007, 1008, 1009}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1103})) {
                    return new State진행04오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행04오브젝트 : TriggerState {
            internal State진행04오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003498, textId: 20003498);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetActor(triggerId: 204, visible: false, initialSequence: "Idle_A");
                context.SetInteractObject(interactIds: new []{10000809}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000809}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003498);
                    return new State진행04Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행04Monster : TriggerState {
            internal State진행04Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{39104}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1010, 1011, 1012}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1104})) {
                    return new State진행05오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행05오브젝트 : TriggerState {
            internal State진행05오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003499, textId: 20003499);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetActor(triggerId: 205, visible: false, initialSequence: "Idle_A");
                context.SetInteractObject(interactIds: new []{10000810}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000810}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003499);
                    return new State진행05Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행05Monster : TriggerState {
            internal State진행05Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{39105}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1013, 1014, 1015}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1105})) {
                    return new State진행06오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행06오브젝트 : TriggerState {
            internal State진행06오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003500, textId: 20003500);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetActor(triggerId: 206, visible: false, initialSequence: "Idle_A");
                context.SetInteractObject(interactIds: new []{10000811}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000811}, arg2: 0)) {
                    context.SetAchievement(triggerId: 100, type: "trigger", code: "rescue_boroboro");
                    context.HideGuideSummary(entityId: 20003500);
                    return new State진행06Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행06Monster : TriggerState {
            internal State진행06Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{39106}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1016, 1017, 1018, 1019, 1020}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1106})) {
                    return new State레논오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논오브젝트 : TriggerState {
            internal State레논오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003495, textId: 20003495);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetActor(triggerId: 207, visible: false, initialSequence: "Idle_A");
                context.SetInteractObject(interactIds: new []{10000812}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000812}, arg2: 0)) {
                    context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020});
                    context.HideGuideSummary(entityId: 20003495);
                    return new State레논구출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논구출 : TriggerState {
            internal State레논구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
                context.SetSkip(state: new State레논구출종료(context));
                context.DestroyMonster(spawnIds: new []{2001});
                context.CreateMonster(spawnIds: new []{2002});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State레논Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script01 : TriggerState {
            internal State레논Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6101}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$02000349_BF__MAIN__3$", arg4: 3);
                context.SetSkip(state: new State레논구출종료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script02 : TriggerState {
            internal State레논Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6102}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$02000349_BF__MAIN__4$", arg4: 3);
                context.SetSkip(state: new State레논구출종료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논구출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논구출종료 : TriggerState {
            internal State레논구출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{301}, returnView: true);
            }

            public override TriggerState? Execute() {
                return new State진행07(context);
            }

            public override void OnExit() { }
        }

        private class State진행07 : TriggerState {
            internal State진행07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 301, enable: false);
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData2002_AB");
                context.ShowGuideSummary(entityId: 20003501, textId: 20003501, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 127, spawnIds: new []{2002})) {
                    return new State진행07Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행07Monster : TriggerState {
            internal State진행07Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1021});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1021})) {
                    return new State진행08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행08 : TriggerState {
            internal State진행08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData2002_C");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 128, spawnIds: new []{2002})) {
                    context.SetSkill(triggerIds: new []{701}, arg2: true);
                    context.SetEffect(triggerIds: new []{6201}, visible: true);
                    context.DestroyMonster(spawnIds: new []{2002});
                    context.CreateMonster(spawnIds: new []{2003});
                    return new State진행09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행09 : TriggerState {
            internal State진행09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData2002_C");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{129})) {
                    return new State진행09Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행09Monster : TriggerState {
            internal State진행09Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2003, patrolName: "MS2PatrolData2003_A");
                context.CreateMonster(spawnIds: new []{1022});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1022})) {
                    return new State진행10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행10 : TriggerState {
            internal State진행10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2003, patrolName: "MS2PatrolData2003_B");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 130, spawnIds: new []{2003})) {
                    context.SetSkill(triggerIds: new []{702}, arg2: true);
                    context.SetEffect(triggerIds: new []{6202}, visible: true);
                    context.DestroyMonster(spawnIds: new []{2003});
                    context.CreateMonster(spawnIds: new []{2004});
                    return new State진행11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행11 : TriggerState {
            internal State진행11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{131})) {
                    return new State진행11Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행11Monster : TriggerState {
            internal State진행11Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2004, patrolName: "MS2PatrolData2004_A");
                context.CreateMonster(spawnIds: new []{1023});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1023})) {
                    return new State진행12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행12 : TriggerState {
            internal State진행12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2004, patrolName: "MS2PatrolData2004_B");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 132, spawnIds: new []{2004})) {
                    context.SetSkill(triggerIds: new []{703}, arg2: true);
                    context.SetEffect(triggerIds: new []{6203}, visible: true);
                    context.DestroyMonster(spawnIds: new []{2004});
                    context.CreateMonster(spawnIds: new []{2005});
                    return new State진행13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행13 : TriggerState {
            internal State진행13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{133})) {
                    return new State진행13Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행13Monster : TriggerState {
            internal State진행13Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2005, patrolName: "MS2PatrolData2005_A");
                context.CreateMonster(spawnIds: new []{1024});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1024})) {
                    return new State진행14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행14 : TriggerState {
            internal State진행14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2005, patrolName: "MS2PatrolData2005_B");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 134, spawnIds: new []{2005})) {
                    context.SetSkill(triggerIds: new []{704}, arg2: true);
                    context.SetEffect(triggerIds: new []{6204}, visible: true);
                    context.DestroyMonster(spawnIds: new []{2005});
                    context.CreateMonster(spawnIds: new []{2007});
                    return new State진행15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행15 : TriggerState {
            internal State진행15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{135})) {
                    return new State카트반CinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반CinematicDelay : TriggerState {
            internal State카트반CinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1099}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카드반StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반StartCinematic : TriggerState {
            internal State카드반StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 302, enable: true);
                context.SetSkip(state: new State카드반StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카드반Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script01 : TriggerState {
            internal State카드반Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 24001705, script: "$02000349_BF__MAIN__5$", arg4: 3);
                context.SetSkip(state: new State카드반StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State카드반Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script02 : TriggerState {
            internal State카드반Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 24001705, script: "$02000349_BF__MAIN__6$", arg4: 4);
                context.SetSkip(state: new State카드반StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State레논Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script05 : TriggerState {
            internal State레논Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 303, enable: true);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$02000349_BF__MAIN__7$", arg4: 4);
                context.SetSkip(state: new State카드반StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State카드반Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script03 : TriggerState {
            internal State카드반Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: true);
                context.SetConversation(type: 2, spawnId: 24001705, script: "$02000349_BF__MAIN__8$", arg4: 6);
                context.SetSkip(state: new State카드반StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State카드반Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script04 : TriggerState {
            internal State카드반Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: true);
                context.SetConversation(type: 2, spawnId: 24001705, script: "$02000349_BF__MAIN__9$", arg4: 8);
                context.SetSkip(state: new State카드반StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State카드반Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script05 : TriggerState {
            internal State카드반Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: true);
                context.CreateMonster(spawnIds: new []{1025, 1026}, arg2: false);
                context.SetConversation(type: 2, spawnId: 24001705, script: "$02000349_BF__MAIN__10$", arg4: 7);
                context.SetSkip(state: new State카드반StopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State카드반StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반StopCinematic : TriggerState {
            internal State카드반StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003502, textId: 20003502, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.DestroyMonster(spawnIds: new []{1025, 1026, 1099});
                context.SetAgent(triggerIds: new []{901, 902, 903, 904}, visible: false);
                context.DestroyMonster(spawnIds: new []{2007});
                context.CreateMonster(spawnIds: new []{2006});
                context.CameraSelectPath(pathIds: new []{302}, returnView: true);
            }

            public override TriggerState? Execute() {
                return new State진행16(context);
            }

            public override void OnExit() { }
        }

        private class State진행16 : TriggerState {
            internal State진행16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 302, enable: false);
                context.CameraSelect(triggerId: 303, enable: false);
                context.MoveNpc(spawnId: 2006, patrolName: "MS2PatrolData2006_A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 136, spawnIds: new []{2006})) {
                    return new State진행17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행17 : TriggerState {
            internal State진행17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1025, 1026, 1099}, arg2: false);
                context.SetAgent(triggerIds: new []{901, 902, 903, 904}, visible: true);
                context.SetMesh(triggerIds: new []{3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815, 3816}, visible: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new StateDungeonEndingCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonEndingCinematicDelay : TriggerState {
            internal StateDungeonEndingCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2006});
                context.CreateMonster(spawnIds: new []{2008});
                context.DestroyMonster(spawnIds: new []{1025, 1026});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDungeon종료StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeon종료StopCinematic : TriggerState {
            internal StateDungeon종료StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2008, script: "$02000349_BF__MAIN__11$", arg4: 3);
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2008, script: "$02000349_BF__MAIN__13$", arg4: 4);
                context.MoveNpc(spawnId: 2008, patrolName: "MS2PatrolData2008_A");
                context.SetEffect(triggerIds: new []{6205}, visible: true);
                context.SetMesh(triggerIds: new []{3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.DestroyMonster(spawnIds: new []{2008});
                    context.HideGuideSummary(entityId: 20003493);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
